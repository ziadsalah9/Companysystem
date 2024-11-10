using Companysystem.Clientforms;
using Companysystem.Dtos;
using Companysystem.ItemsForms;
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

namespace Companysystem.SalesForms
{
    public partial class SalesBillsFormKy : BaseForm
    {

        private readonly StoreContext context;
        public SalesBillsFormKy()
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



            context = new StoreContext();
        }

        private void SalesBillsFormKy_Load(object sender, EventArgs e)
        {
            using (var context = new StoreContext())
            {

                //var result = context.Salesd.Include(p => p.Client).Include(p => p.Item).ToList();

                // Map the result to SalesDto
                //  var data = _mapper.Map<IEnumerable<SalesDto>>(result);

                //   var data = context.Salesd.ToList();
                var dataa = context.Salesd
                         .Include(p => p.Client).Include(p => p.Item)
                         .Select(p => new SalesDto
                         {
                             quantity = p.quantity,
                             Price = p.Price,
                             Date = p.Date,
                             Client = p.Client.Name,
                             clientID = p.Client.Id,
                             deduct = p.deduct,
                             Commissions = p.Commissions,
                             month = p.month,
                             NetPriceValue = p.NetPriceValue,
                             Notes = p.Notes,
                             Id = p.Id,
                             Item = p.Item.Name,
                             priceValue = p.priceValue,
                             ItemfkId = p.ItemfkId
                         })
                         .ToList();

                //  Bind the mapped data to the DataGridView
                dv.DataSource = dataa.ToList();

                dv.Columns["Id"].HeaderText = "رقم الفاتورة";
                dv.Columns["month"].HeaderText = "الشهر";
                dv.Columns["Date"].HeaderText = "التاريخ";
                dv.Columns["Client"].HeaderText = "العميل";
                dv.Columns["clientID"].HeaderText = "رقم العميل";
                dv.Columns["item"].HeaderText = "الصنف";
                dv.Columns["itemfkid"].HeaderText = "رقم الصنف";
                dv.Columns["quantity"].HeaderText = "الكمية";
                dv.Columns["price"].HeaderText = "السعر";
                dv.Columns["priceValue"].HeaderText = "القيمة";
                dv.Columns["deduct"].HeaderText = "الخصم";
                dv.Columns["Commissions"].HeaderText = "العمولات";
                dv.Columns["NetPriceValue"].HeaderText = "صافى القيمة";
                dv.Columns["Notes"].HeaderText = "الملاحظات";







            }
        }

        private void dv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            var clients = context.clients.ToList();
            var items = context.items.ToList();

            if (clients.Count() <= 0)
            {
                MessageBox.Show("لا يوجد عملاء, من فضلك قم باضافة عميل");
                AddClientFormKy f = new ();
                f.Show();
                Hide();

            }

            else if (items.Count() <= 0)
            {
                MessageBox.Show("لا يوجد أصناف, من فضلك قم بالاضافة");
                AddItemKy af = new ();
                af.Show();

                Hide();

            }
            else
            {

                AddSalesBillsFormKy s = new ();
                s.Show();
                Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 ky = new Form1();
            ky.Show();
            Hide();
        }
    }
}
