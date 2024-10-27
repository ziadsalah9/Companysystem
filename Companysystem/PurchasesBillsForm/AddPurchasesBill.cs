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

            listitemsname.SelectedIndexChanged += listitemsname_SelectedIndexChanged;


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

           var name = context.items.FirstOrDefault(p => p.Id == (itemfk)).Name;

                var Store = new Store
                {
                    PurchasesBillId = data.Id,
                    price =data.Price*1.5m,
                    BeginingStore = 0,
                    incoming = data.quantity    ,
                    EndingStore = data.quantity ,
                    InventoryCost = (data.quantity*data.priceUnit),
                    item = name,
                    
                    



                };



                context.Stores.Add(Store);
                context.SaveChanges();
                MessageBox.Show("تمت الاضافة بنجاح");
                var purchaseb = new PurchsesBillForm();
                purchaseb.Show();
                Hide();

                #region
                //// var idname = listitemsname.SelectedValue;

                //var name = context.items.FirstOrDefault(p => p.Id == (int)listitemsname.SelectedValue);




                //var Endst = context.Stores.OrderByDescending(p => p.Id).FirstOrDefault(p => p.item == name.Name);

                //// لو هو موجود فى الداتا بيز يبقى ثبت سعر يونيت برايس

                ////var update = context.Stores.OrderByDescending(p => p.Id).FirstOrDefault(p => p.item == name.Name && p.PurchasesBill.quantity==(int)quantitynum.Value

                ////&&p.PurchasesBill.Customs== CustomsNum.Value && p.PurchasesBill.deduct== discountnum.Value && p.PurchasesBill.TransportAndShipping== transportandshippingnum.Value && p.PurchasesBill.others== transportandshippingnum.Value



                ////);


                //// ده بيجيب الفواتير علشان اقدر اجيب منه اليونت برايس واضربه فى الكوانتيتي فيطلعلى انفونترى كوست
                //// هو مش مظبوط ممكن اشيله السطر ده بس
                //var purchsesbillpriceunit = context.Purchases.OrderByDescending(p => p.Id).FirstOrDefault();

                //if (Endst is null)
                //{
                //    var store = new Store
                //    {
                //        PurchasesBillId = data.Id,
                //        item = data.Item.Name,
                //        price = data.Price * 1.5m,
                //        incoming = data.quantity,
                //        BeginingStore = 0,

                //        EndingStore = data.quantity,
                //        InventoryCost = data.quantity * data.priceUnit,




                //    };
                //    context.Stores.Add(store);
                //    context.SaveChanges();

                //    MessageBox.Show("تمت الاضافة بنجاح");


                //}



                //else
                //{
                //    var store = new Store
                //    {
                //        PurchasesBillId = data.Id,
                //        item = data.Item.Name,
                //        price = data.Price * 1.5m,
                //        incoming = data.quantity,
                //        BeginingStore = Endst.EndingStore,

                //        EndingStore = Endst.EndingStore + data.quantity,
                //        InventoryCost = (Endst.EndingStore + data.quantity) * purchsesbillpriceunit.priceUnit,



                //    };
                //    context.Stores.Add(store);
                //    context.SaveChanges();
                //    MessageBox.Show("تمت الاضافة بنجاح");


                //  }

                #endregion
            }



        }

        private void listsuppliersname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listitemsname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var purchaseb = new PurchsesBillForm();
            purchaseb.Show();
            Hide();
        }
    }
}
