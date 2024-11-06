using Companysystem.Clientforms;
using Companysystem.Dtos;
using Companysystem.ItemsForms;
using Companysystem.Models;
using Companysystem.SalesForms;
using Companysystem.Supllierforms;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Companysystem.PurchasesBillsForm
{
    public partial class PurchsesBillForm : Form
    {
        private readonly StoreContext context;
        public PurchsesBillForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            context = new StoreContext();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            var suppliers = context.Suppliers.ToList();
            var items = context.items.ToList();

            if (suppliers.Count() <= 0)
            {
                MessageBox.Show("لا يوجد موردين, من فضلك قم بالاضافة");
                ADDsupplierform f = new ADDsupplierform();
                f.Show();
                Hide();

            }

            else if (items.Count() <= 0)
            {
                MessageBox.Show("لا يوجد أصناف, من فضلك قم بالاضافة");
                AddItemForm af = new AddItemForm();
                af.Show();

                Hide();

            }
            else
            {

                AddPurchasesBill addPurchasesBill = new AddPurchasesBill();
                addPurchasesBill.Show();
                Hide();
            }

        }

        private void PurchsesBillForm_Load(object sender, EventArgs e)
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
                             Customs = p.Customs ,
                             deduct = p.deduct,
                             Id = p.Id,
                             month = p.month,
                             ItemId =p.ItemId,
                             others = p.others,
                             NetPriceValue = p.NetPriceValue,
                             priceUnit = p.priceUnit,
                             PriceValue = p.PriceValue,
                             TransportAndShipping = p.TransportAndShipping,
                             SupplierId = p.SupplierId
                         })
                         .ToList();

         //    context.Purchases.Where(p=>p.ItemId)
                ShowBilldv.DataSource = data.ToList();

                ShowBilldv.Columns["Id"].HeaderText = "رقم الفاتورة";
                ShowBilldv.Columns["month"].HeaderText = "الشهر";
                ShowBilldv.Columns["Date"].HeaderText = "التاريخ";
                ShowBilldv.Columns["Supplier"].HeaderText = "المورد";
                ShowBilldv.Columns["SupplierId"].HeaderText = "رقم المورد";
                ShowBilldv.Columns["item"].HeaderText = "الصنف";
                ShowBilldv.Columns["ItemId"].HeaderText = "رقم الصنف";
                ShowBilldv.Columns["quantity"].HeaderText = "الكمية";
                ShowBilldv.Columns["price"].HeaderText = "السعر";
                ShowBilldv.Columns["priceValue"].HeaderText = "القيمة";
                ShowBilldv.Columns["deduct"].HeaderText = "الخصم";
                ShowBilldv.Columns["Customs"].HeaderText = "جمارك";
                ShowBilldv.Columns["others"].HeaderText = "اخرى";
                ShowBilldv.Columns["TransportAndShipping"].HeaderText = "نقل و شحن ";
                ShowBilldv.Columns["priceUnit"].HeaderText ="تكلفة الوحدة";
                ShowBilldv.Columns["NetPriceValue"].HeaderText = "صافى القيمة";





            }
        }
    }
}
