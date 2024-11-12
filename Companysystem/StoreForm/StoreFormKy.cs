using Companysystem.Dtos;
using Companysystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Jenga.Theme;

namespace Companysystem.StoreForm
{
    public partial class StoreFormKy : BaseForm
    {
        public StoreFormKy()
        {
            InitializeComponent();
            // تأكد من تعيين WrapMode إلى DataGridViewTriState.True
            dv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // يمكنك أيضًا ضبط ارتفاع الصف تلقائيًا ليتناسب مع النص
            dv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            // تأكد من تعيين WrapMode إلى DataGridViewTriState.True لرؤوس الأعمدة
            dv.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // يمكنك أيضًا ضبط ارتفاع رؤوس الأعمدة تلقائيًا ليتناسب مع النص
            dv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.StartPosition = FormStartPosition.CenterScreen;


        }

        private void StoreFormKy_Load(object sender, EventArgs e)
        {

            using (var context = new StoreContext())
            {


                var data = context.Stores
                      .Include(p => p.PurchasesBill)
                      .Select(p => new StoreDto
                      {
                          Id = p.Id,
                          month = p.PurchasesBill.Date.Month.ToString(),
                          Date = p.PurchasesBill.Date,
                          Item = p.PurchasesBill.Item.Name,
                          BillNumber = p.PurchasesBill.Id,
                          Supplier = p.PurchasesBill.Supplier.Name,
                          PricefromBill = p.PurchasesBill.Price,
                          Price = p.price,
                          BeginingStore = p.BeginingStore,
                          incoming = p.incoming,
                          outgoing = p.outgoing,
                          EndingStore = p.EndingStore,
                          InventoryCost = p.InventoryCost,
                      })
                .ToList();

                dv.DataSource = data;
                dv.Columns["month"].HeaderText = "الشهر";
                dv.Columns["Date"].HeaderText = "التاريخ";
                dv.Columns["BillNumber"].HeaderText = "فاتورة المبيعات";
                dv.Columns["Supplier"].HeaderText = "المورد";
                dv.Columns["Item"].HeaderText = "الصنف";
                dv.Columns["PriceFromBill"].HeaderText = "التكلفة";
                dv.Columns["Price"].HeaderText = "سعر البيع";
                dv.Columns["BeginingStore"].HeaderText = " أول المدة";
                dv.Columns["incoming"].HeaderText = "الوارد";
                dv.Columns["outgoing"].HeaderText = "الصادر";
                dv.Columns["EndingStore"].HeaderText = " اخر المدة";
                dv.Columns["InventoryCost"].HeaderText = " تكلفة المخزون";







            }





        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // تحقق من أن العمود هو العمود الذي تريد تلوينه
            if (dv.Columns[e.ColumnIndex].Name == "InventoryCost")
            {
                // قم بتعيين لون الخلفية واللون الأمامي للخلية
                e.CellStyle.BackColor = Color.Yellow;
                e.CellStyle.ForeColor = Color.Red;
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var h = new HomeForm();
            h.Show();
            Hide();
        }

        private void dv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dv.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);

        }
    }
}
