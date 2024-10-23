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
    public partial class AddPurchasesBill : Form
    {
        private readonly StoreContext context;
        public AddPurchasesBill()
        {
            InitializeComponent();
            context = new StoreContext();
            
        }



        private void AddPurchasesBill_Load(object sender, EventArgs e)
        {
            var suppliers = context.Suppliers.ToList();
            listsuppliersname.DataSource = suppliers;
            listsuppliersname.DisplayMember = "Name";
            listsuppliersname.ValueMember = "Id";

            var items = context.items.ToList();
            listitemsname.DataSource = items;
            listitemsname.DisplayMember = "Name";
            listitemsname.ValueMember = "Id";


            listsuppliersname.SelectedIndexChanged += listsuppliersname_SelectedIndexChanged;

            listitemsname.SelectedIndexChanged += listitemsname_SelectedIndexChanged  ;


        }



        private void btnadd_Click(object sender, EventArgs e)
        {

            using (var context = new StoreContext())
            {


                int selectedId = (int)listsuppliersname.SelectedValue;
                int itemfk = (int)listitemsname.SelectedValue;

                var value = priceNum.Value * quantitynum.Value;

                var netpricevalue = value - (discountnum.Value) + (transportandshippingnum.Value + CustomsNum.Value + OtherNum.Value)
                    ;


                var data = new Purchases
                {
                    Date = dateTimePicker1.Value,
                    month = dateTimePicker1.Value.Month.ToString(),
                    SupplierId = selectedId,
                    ItemId = itemfk,
                    quantity = (int)quantitynum.Value,
                    Price = priceNum.Value,

                    PriceValue = value,

                    deduct = discountnum.Value,
                    TransportAndShipping = transportandshippingnum.Value,
                    Customs = CustomsNum.Value,
                    others = OtherNum.Value,
                    NetPriceValue = value - (discountnum.Value) + (transportandshippingnum.Value + CustomsNum.Value + OtherNum.Value),
                    priceUnit = ((decimal)Math.Pow(Convert.ToDouble(quantitynum.Value), -1.00)) * netpricevalue

                };





                context.Purchases.Add(data);
                context.SaveChanges();
                var Endst = context.Stores.OrderByDescending(p => p.Id).FirstOrDefault(p => p.item == listsuppliersname.SelectedItem);

                if (Endst is null)
                {
                    var store = new Store
                    {
                        PurchasesBillId = data.Id,
                        item = data.Item.Name,
                        price = data.Price * 1.5m,
                        incoming = data.quantity,
                        BeginingStore =0,

                        EndingStore = Endst.EndingStore+data.quantity,
                        InventoryCost = 50,



                    };
                    context.Stores.Add(store);
                    context.SaveChanges();

                    MessageBox.Show("تمت الاضافة بنجاح");


                }
                else
                {
                    var store = new Store
                    {
                        PurchasesBillId = data.Id,
                        item = data.Item.Name,
                        price = data.Price * 1.5m,
                        incoming = data.quantity,
                        BeginingStore = Endst.BeginingStore,

                        EndingStore = Endst.EndingStore + data.quantity,
                        InventoryCost = 50,



                    };
                    context.Stores.Add(store);
                    context.SaveChanges();

                }
            }



        }

        private void listsuppliersname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listitemsname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
