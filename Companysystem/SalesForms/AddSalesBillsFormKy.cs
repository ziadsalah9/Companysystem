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
    public partial class AddSalesBillsFormKy : BaseForm
    {
        private readonly StoreContext context;
        public AddSalesBillsFormKy()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            context = new StoreContext();
        }

        private void AddSalesBillsFormKy_Load(object sender, EventArgs e)
        {

            var clients = context.clients.OrderBy(p => p.Name).ToList();


            kryptonListclients.DataSource = clients;
            kryptonListclients.DisplayMember = "Name";
            kryptonListclients.ValueMember = "Id";

            var items = context.items.OrderBy(p => p.Name).ToList();
            kryptonListitems.DataSource = items;
            kryptonListitems.DisplayMember = "Name";
            kryptonListitems.ValueMember = "Id";



            kryptonListclients.SelectedIndexChanged += kryptonListclients_SelectedIndexChanged;
            kryptonListitems.SelectedIndexChanged += kryptonListitems_SelectedIndexChanged;


            if (clients.Count() <= 0)
            {
                MessageBox.Show("لا يوجد عملاء, من فضلك قم باضافة عميل");
                AddClientFormKy f = new();
                f.Show();

            }

            if (items.Count() <= 0)
            {
                MessageBox.Show("لا يوجد أصناف, من فضلك قم بالاضافة");
                AddItemKy af = new();
                af.Show();
                Hide();

            }

        }

        private void kryptonListclients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonListitems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

            int selectedId = (int)kryptonListclients.SelectedValue;
            int itemfk = (int)kryptonListitems.SelectedValue;
            if (selectedId.ToString() is not null || itemfk.ToString() is not null)
            {

                //MessageBox.Show($"Selected ID: {selectedId}");
                //MessageBox.Show($"select id  : {itemfk}");





                string name = context.items.FirstOrDefault(p => p.Id == itemfk).Name;
                var still = context.Stores.Where(p => p.item == name).Sum(p => p.EndingStore);



                //context.SaveChanges();

                var firstenterdinstore = context.Stores.FirstOrDefault(p => p.item == name && p.EndingStore != 0);
                //   var firstenterdinstore = context.Stores.FirstOrDefault(p=>p.item==sale.Item.Name);

                var sale = new Sales
                {
                    clientID = selectedId,
                    Date = kryptonDate.Value,
                    month = kryptonDate.Value.Month,
                    ItemfkId = itemfk,
                    quantity = kryptonquantity.Value,
                    Commissions = kryptoncommision.Value,
                    deduct = kryptondiscount.Value,
                    Notes = noticestxt.Text,
                    Price = kryptonprice.Value,
                    priceValue = kryptonquantity.Value * kryptonprice.Value,
                    NetPriceValue = (kryptonquantity.Value * kryptonprice.Value) - (kryptondiscount.Value + kryptoncommision.Value),

                };

                if (firstenterdinstore is not null)
                {
                    #region important
                    if (sale.quantity <= firstenterdinstore.EndingStore)
                    {






                        firstenterdinstore.Id = firstenterdinstore.Id;
                        firstenterdinstore.price = firstenterdinstore.price;
                        firstenterdinstore.PurchasesBillId = firstenterdinstore.PurchasesBillId;
                        firstenterdinstore.outgoing = firstenterdinstore.outgoing + kryptonquantity.Value;
                        firstenterdinstore.EndingStore = (firstenterdinstore.BeginingStore + firstenterdinstore.incoming) - firstenterdinstore.outgoing;
                        firstenterdinstore.InventoryCost = firstenterdinstore.priceUnit * firstenterdinstore.EndingStore;
                        firstenterdinstore.item = firstenterdinstore.item;
                        firstenterdinstore.priceUnit = firstenterdinstore.priceUnit;
                        context.SaveChanges();



                        context.Salesd.Add(sale);

                        context.SaveChanges();
                        string message = "تمت العملية بنجاح!";
                        string tittle = "نجاح";
                        MessageBox.Show(message, tittle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var trans = new StoreTransaction
                        {
                            purchasessId = firstenterdinstore.PurchasesBillId,
                            storessId = firstenterdinstore.Id,
                            quantity = sale.quantity,
                            salessId = sale.Id
                        };

                        context.Add(trans);
                        context.SaveChanges();





                        var billsfor = new SalesBillsFormKy();
                        billsfor.Show();
                        Hide();
                    }
                    #endregion

                    #region باقى اهندل حالة انى ابيع بس يكون اكبر من اول صف بس مش اكبر من كل المخزون
                    else if (sale.quantity > firstenterdinstore.EndingStore && firstenterdinstore.EndingStore != 0 && sale.quantity <= still)
                    {
                        var fi = context.Stores.Where(p => p.EndingStore != 0 && p.item == name).ToList();
                        var remainingQuantity = kryptonquantity.Value;

                        var sale2 = new Sales
                        {


                            clientID = selectedId,
                            Date = kryptonDate.Value,
                            month = kryptonDate.Value.Month,
                            ItemfkId = itemfk,
                            quantity = kryptonquantity.Value,
                            Commissions = kryptoncommision.Value,
                            deduct = kryptondiscount.Value,
                            Notes = noticestxt.Text,
                            Price = kryptonprice.Value,
                            priceValue = kryptonquantity.Value * kryptonprice.Value,
                            NetPriceValue = (kryptonquantity.Value * kryptonprice.Value) - (kryptondiscount.Value + kryptoncommision.Value),
                        };
                        context.Add(sale2);
                        context.SaveChanges();

                        foreach (var item in fi)
                        {
                            if (remainingQuantity > item.EndingStore)
                            {
                                remainingQuantity -= item.EndingStore;
                                item.outgoing += item.EndingStore;
                                item.InventoryCost -= item.EndingStore * item.priceUnit; // Update the cost

                                var tans = new StoreTransaction
                                {
                                    storessId = item.Id,
                                    purchasessId = item.PurchasesBillId,
                                    salessId = sale2.Id,
                                    quantity = item.EndingStore,


                                };
                                item.EndingStore = 0;

                                context.Add(tans);
                                context.SaveChanges();
                            }
                            else
                            {
                                item.EndingStore -= remainingQuantity;
                                item.outgoing += remainingQuantity;
                                item.InventoryCost -= item.EndingStore * item.priceUnit; // Update the cost


                                var tans = new StoreTransaction
                                {
                                    storessId = item.Id,
                                    purchasessId = item.PurchasesBillId,
                                    salessId = sale2.Id,
                                    quantity = remainingQuantity,


                                };
                                remainingQuantity = 0;


                                context.Add(tans);
                                context.SaveChanges();


                                break; // Exit the loop as we have fulfilled the sale quantity
                            }
                        }

                        context.SaveChanges();
                        string message = "تمت العملية بنجاح!";
                        string tittle = "نجاح";
                        MessageBox.Show(message, tittle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //firstenterdinstore.Id = firstenterdinstore.Id;
                        //firstenterdinstore.price = firstenterdinstore.price;
                        //firstenterdinstore.BeginingStore = firstenterdinstore.BeginingStore;
                        //firstenterdinstore.incoming = firstenterdinstore.incoming;
                        //firstenterdinstore.outgoing =firstenterdinstore.incoming;
                        //firstenterdinstore.PurchasesBillId = firstenterdinstore.PurchasesBillId;
                        //firstenterdinstore.EndingStore = 0;
                        //firstenterdinstore.InventoryCost = firstenterdinstore.priceUnit * firstenterdinstore.EndingStore;
                        //firstenterdinstore.item = firstenterdinstore.item;
                        //firstenterdinstore.priceUnit = firstenterdinstore.priceUnit;


                        //  MessageBox.Show("");









                        var billsfor = new SalesBillsFormKy();
                        billsfor.Show();
                        Hide();

                    }
                    #endregion

                    else if (sale.quantity > firstenterdinstore.EndingStore && sale.quantity > still)
                    {

                        var fi = context.Stores.Where(p => p.EndingStore != 0 && p.item == name).ToList();



                        var sale2 = new Sales
                        {
                            clientID = selectedId,
                            Date = kryptonDate.Value,
                            month = kryptonDate.Value.Month,
                            ItemfkId = itemfk,
                            quantity = firstenterdinstore.EndingStore,
                            Commissions = kryptoncommision.Value,
                            deduct = kryptondiscount.Value,
                            Notes = noticestxt.Text,
                            Price = kryptonprice.Value,
                            priceValue = kryptonquantity.Value * kryptonprice.Value,
                            NetPriceValue = (kryptonquantity.Value * kryptonquantity.Value) - (kryptondiscount.Value + kryptoncommision.Value),

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

                        // context.Salesd.Add(sale2);
                        //// context.Stores.Add(store);
                        // context.Stores.Remove(firstenterdinstore);
                        // context.SaveChanges();




                        OkOrNotWhenQuanityGreaterThanEndingStoreKy okornottky = new OkOrNotWhenQuanityGreaterThanEndingStoreKy(still, sale2, fi);
                        okornottky.Show();
                        Hide();

                    }
                    else
                    {
                        MessageBox.Show("لا يوجد هذا الصنف فى المخزن");

                    }

                }
                else
                {
                    MessageBox.Show("لا يوجد هذا الصنف فى المخزن");
                }





            }



        }


    }
}
