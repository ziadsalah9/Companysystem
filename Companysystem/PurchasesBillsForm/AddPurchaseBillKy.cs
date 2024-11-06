using Companysystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Companysystem.PurchasesBillsForm
{
    public partial class AddPurchaseBillKy : BaseForm
    {
        StoreContext context;
        public AddPurchaseBillKy()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            context = new StoreContext();
        }

        private void AddPurchaseBillKy_Load(object sender, EventArgs e)
        {
            var suppliers = context.Suppliers.ToList();
            kryptonListsuppliers.DataSource = suppliers;
            kryptonListsuppliers.DisplayMember = "Name";
            kryptonListsuppliers.ValueMember = "Id";

            var items = context.items.ToList();
            kryptonListitems.DataSource = items;
            kryptonListitems.DisplayMember = "Name";
            kryptonListitems.ValueMember = "Id";

                   kryptonListsuppliers.SelectedIndexChanged += kryptonListsuppliers_SelectedIndexChanged;
                   kryptonListitems.SelectedIndexChanged += kryptonListitems_SelectedIndexChanged;
        }

        private void kryptonLabel8_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            using (var context = new StoreContext())
            {
                int selectedId = (int)kryptonListsuppliers.SelectedValue;
                int itemfk = (int)kryptonListsuppliers.SelectedValue;

                var value = kryptonprice.Value * kryptonquantity.Value;
                var netpricevalue = value - kryptondiscount.Value + (kryptontransport.Value + kryptonjamaric.Value + kryptonother.Value);

               
                var data = new Purchases
                {
                    Date = kryptonDate.Value,
                    month = kryptonDate.Value.Month.ToString(),
                    SupplierId = selectedId,
                    ItemId = itemfk,
                    quantity = kryptonquantity.Value,

                    Price = kryptonprice.Value,
                    PriceValue = value,
                    deduct = kryptondiscount.Value,
                    TransportAndShipping = kryptontransport.Value,
                    Customs = kryptonjamaric.Value,
                    others = kryptonother.Value,

                    NetPriceValue = netpricevalue,
                    priceUnit = ((decimal)Math.Pow(Convert.ToDouble(kryptonquantity.Value), -1.00)) * netpricevalue
                };
               
                context.Purchases.Add(data);
                context.SaveChanges();

                var name = context.items.FirstOrDefault(p => p.Id == itemfk).Name;

                var store = new Store
                {
                    PurchasesBillId = data.Id,
                    price = data.Price * 1.5m,
                    BeginingStore = kryptonbigningnum.Value,
                    incoming = data.quantity,
                    EndingStore = data.quantity + kryptonbigningnum.Value,
                    InventoryCost = (data.quantity + kryptonbigningnum.Value) * data.priceUnit,
                    item = name,
                    priceUnit = data.priceUnit
                };

                context.Stores.Add(store);
                context.SaveChanges();
                string message = "تمت العملية بنجاح!";
                string tittle = "نجاح";
                MessageBox.Show(message, tittle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                var purchaseb = new PurchasesBillSormKy();
                purchaseb.Show();
                Hide();
            }
        }

        private void kryptonListsuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonListitems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
