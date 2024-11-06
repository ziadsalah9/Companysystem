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

namespace Companysystem.PurchasesBillsForm
{
    public partial class PurchasesBillSormKy : BaseForm
    {
        public PurchasesBillSormKy()
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


        }

        private void PurchasesBillSormKy_Load(object sender, EventArgs e)
        {

            using (var context = new StoreContext())
            {

                var data = context.Purchases
                         .Include(p => p.Supplier)
                         .Select(p => new PurchaseDto
                         {
                             quantity = p.quantity,
                             Price = p.Price,
                             Date = p.Date,
                             Supplier = p.Supplier.Name,
                             Item = p.Item.Name,
                             Customs = p.Customs,
                             deduct = p.deduct,
                             Id = p.Id,
                             month = p.month,
                             ItemId = p.ItemId,
                             others = p.others,
                             NetPriceValue = p.NetPriceValue,
                             priceUnit = p.priceUnit,
                             PriceValue = p.PriceValue,
                             TransportAndShipping = p.TransportAndShipping,
                             SupplierId = p.SupplierId
                         })
                         .ToList();

                //    context.Purchases.Where(p=>p.ItemId)
                dv.DataSource = data.ToList();

                dv.Columns["Id"].HeaderText = "رقم الفاتورة";
                dv.Columns["month"].HeaderText = "الشهر";
                dv.Columns["Date"].HeaderText = "التاريخ";
                dv.Columns["Supplier"].HeaderText = "المورد";
                dv.Columns["SupplierId"].HeaderText = "رقم المورد";
                dv.Columns["item"].HeaderText = "الصنف";
                dv.Columns["ItemId"].HeaderText = "رقم الصنف";
                dv.Columns["quantity"].HeaderText = "الكمية";
                dv.Columns["price"].HeaderText = "السعر";
                dv.Columns["priceValue"].HeaderText = "القيمة";
                dv.Columns["deduct"].HeaderText = "الخصم";
                dv.Columns["Customs"].HeaderText = "جمارك";
                dv.Columns["others"].HeaderText = "اخرى";
                dv.Columns["TransportAndShipping"].HeaderText = "نقل و شحن ";
                dv.Columns["priceUnit"].HeaderText = "تكلفة الوحدة";
                dv.Columns["NetPriceValue"].HeaderText = "صافى القيمة";

            }
        }

        private void dv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form = new();
            form.Show();
            Hide();
        }
    }
}
