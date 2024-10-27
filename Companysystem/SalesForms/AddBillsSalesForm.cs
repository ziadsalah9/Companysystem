using AutoMapper;
using Companysystem.Clientforms;
using Companysystem.ItemsForms;
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

namespace Companysystem.SalesForms
{
    public partial class AddBillsSalesForm : Form
    {
        private readonly StoreContext context;

        public AddBillsSalesForm()
        {
            InitializeComponent();
            context = new StoreContext();

        }



        private void AddBillsSalesForm_Load(object sender, EventArgs e)
        {



            var clients = context.clients.ToList();


            listclientsname.DataSource = clients;
            listclientsname.DisplayMember = "Name";
            listclientsname.ValueMember = "Id";

            var items = context.items.ToList();
            listitemsname.DataSource = items;
            listitemsname.DisplayMember = "Name";
            listitemsname.ValueMember = "Id";



            listclientsname.SelectedIndexChanged += listclientsname_SelectedIndexChanged;
            listitemsname.SelectedIndexChanged += listitemsname_SelectedIndexChanged;


            if (clients.Count() <= 0)
            {
                MessageBox.Show("لا يوجد عملاء, من فضلك قم باضافة عميل");
                AddClientForm f = new AddClientForm();
                f.Show();

            }

            if (items.Count() <= 0)
            {
                MessageBox.Show("لا يوجد أصناف, من فضلك قم بالاضافة");
                AddItemForm af = new AddItemForm();
                af.Show();
                Hide();

            }
        }

        private void listclientsname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listitemsname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnadd_Click(object sender, EventArgs e)
        {
            int selectedId = (int)listclientsname.SelectedValue;
            int itemfk = (int)listitemsname.SelectedValue;
            if (selectedId.ToString() is not null || itemfk.ToString() is not null)
            {

                MessageBox.Show($"Selected ID: {selectedId}");
                MessageBox.Show($"select id  : {itemfk}");

                var sale = new Sales
                {
                    clientID = selectedId,
                    Date = dateTimePicker1.Value,
                    month = dateTimePicker1.Value.Month,
                    ItemfkId = itemfk,
                    quantity = (int)quantitynum.Value,
                    Commissions = commissionsnum.Value,
                    deduct = discountnum.Value,
                    Notes = noticestxt.Text,
                    Price = priceNum.Value,
                    priceValue = quantitynum.Value * priceNum.Value,
                    NetPriceValue = (quantitynum.Value * priceNum.Value) - (discountnum.Value + commissionsnum.Value),


                };



                string name = context.items.FirstOrDefault(p => p.Id == itemfk).Name;


                //context.SaveChanges();

                var firstenterdinstore = context.Stores.FirstOrDefault(p=>p.item==name);
             //   var firstenterdinstore = context.Stores.FirstOrDefault(p=>p.item==sale.Item.Name);

                if (firstenterdinstore is not null)
                {
                    if (sale.quantity <= firstenterdinstore.EndingStore)
                    {

                        context.Salesd.Add(sale);
                        context.SaveChanges();

                        var store = new Store
                        {
                            outgoing = sale.quantity,
                            salesid = sale.Id,
                            BeginingStore = 0,
                            EndingStore = firstenterdinstore.EndingStore - sale.quantity,
                            item = name,
                            price=firstenterdinstore.price,
                         



                        };

                        context.Stores.Add(store);
                        context.Stores.Remove(firstenterdinstore);
                        context.SaveChanges();


                    }
                    else if (sale.quantity>firstenterdinstore.EndingStore)
                    {


                        var sale2 = new Sales
                        {
                            clientID = selectedId,
                            Date = dateTimePicker1.Value,
                            month = dateTimePicker1.Value.Month,
                            ItemfkId = itemfk,
                            quantity = firstenterdinstore.EndingStore,
                            Commissions = commissionsnum.Value,
                            deduct = discountnum.Value,
                            Notes = noticestxt.Text,
                            Price = priceNum.Value,
                            priceValue = quantitynum.Value * priceNum.Value,
                            NetPriceValue = (quantitynum.Value * priceNum.Value) - (discountnum.Value + commissionsnum.Value),

                        };
                        //var store2 = new Store
                        //{

                        //    outgoing = sale.quantity,
                        //    salesid = sale.Id,
                        //    BeginingStore = 0,
                        //    EndingStore = firstenterdinstore.EndingStore - sale2.quantity,
                        //    item = sale.Item.Name,
                        //    price = firstenterdinstore.price

                        //};

                        context.Salesd.Add(sale2);
                       // context.Stores.Add(store);
                        context.Stores.Remove(firstenterdinstore);
                        context.SaveChanges();

                        MessageBox.Show($"عناصر  {(int)quantitynum.Value - firstenterdinstore.EndingStore} باقى ");

                    }
                    else
                    {
                        MessageBox.Show("no item available");

                    }

                }
                else
                {
                    MessageBox.Show("no item available");
                }

                #region updatestore from sales (old)
                ////   var checkqnatity = context.Stores.OrderByDescending(p=>p.Id).FirstOrDefault(p=>p.PurchasesBill.Item == sale.Item);
                //var checkqnatity = context.Stores.OrderByDescending(p => p.Id).FirstOrDefault(p => p.item == sale.Item.Name);

                //if (checkqnatity != null)
                //{
                //    if (sale.quantity <= checkqnatity.EndingStore)
                //    {

                //        var data = new Store
                //        {
                //            salesid = sale.Id,
                //            outgoing = sale.quantity,
                //            //PurchasesBillId =checkqnatity.PurchasesBillId,
                //            price = checkqnatity.price,
                //            BeginingStore = checkqnatity.EndingStore,
                //            EndingStore = checkqnatity.EndingStore - sale.quantity,
                //            InventoryCost = checkqnatity.EndingStore * checkqnatity.PurchasesBill.Price,
                //            item = sale.Item.Name

                //        };
                //        context.Stores.Add(data);
                //        context.SaveChanges();
                //    }

                //    else
                //    {
                //        var data = new Store
                //        {
                //            salesid = sale.Id,
                //            outgoing = sale.quantity,
                //            //PurchasesBillId =checkqnatity.PurchasesBillId,
                //            price = checkqnatity.price,
                //            BeginingStore = checkqnatity.EndingStore,
                //            EndingStore = 0,
                //            InventoryCost = checkqnatity.EndingStore * checkqnatity.PurchasesBill.Price,
                //            item = sale.Item.Name

                //        };

                //        context.Stores.Add(data);
                //        //       MessageBox.Show($"{checkqnatity.EndingStore} ومتبقى{data.item} من ال {sale.quantity-checkqnatity.EndingStore}لا يوجد كمية كافية فى المخزن قد تم بيع   ");

                //        MessageBox.Show($"{sale.quantity - checkqnatity.EndingStore}لا يوجد كمية كافية فى المخزن . لقد تم بيع");
                //        AddBillsSalesForm addBillsSalesForm = new AddBillsSalesForm();
                //        context.SaveChanges();
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("لا يوجد هذا الصنف فى المخزن");
                //}


                #endregion


                var billsfor = new BillsForms();
                billsfor.Show();
                Hide();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var Billsf =new BillsForms();
            Billsf.Show();
            Hide();
        }
    }
}
