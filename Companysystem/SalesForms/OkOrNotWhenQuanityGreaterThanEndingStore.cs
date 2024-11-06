using Companysystem.Models;
using Companysystem.StoreForm;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Companysystem.SalesForms
{
    public partial class OkOrNotWhenQuanityGreaterThanEndingStore : Form
    {
        List <Store >stores;
        Sales sales1;
        int still;
        public OkOrNotWhenQuanityGreaterThanEndingStore(int number, Sales sales, List <Store> fii)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            still = number;
          //  label2.Text = number.ToString();
            stores = fii;
            sales1 = sales;

        }

        private void OkOrNotWhenQuanityGreaterThanEndingStore_Load(object sender, EventArgs e)
        {
            label2.Text = still.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {



            using (var context = new StoreContext())
            {
                var remainingQuantity = int.Parse(label2.Text);

                sales1.quantity = remainingQuantity;

                context.Add(sales1);
                context.SaveChanges();

                foreach (var item in stores)
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
                            salessId = sales1.Id,
                            quantity = item.EndingStore,


                        };
                        item.EndingStore = 0;

                        context.Add(tans);
                        context.Entry(item).State = EntityState.Modified; // Mark the entity as modified

                        context.SaveChanges();
                    }
                    else
                    {
                        item.EndingStore -= remainingQuantity;
                        item.outgoing += remainingQuantity;
                        item.InventoryCost -= remainingQuantity * item.priceUnit; // Update the cost


                        var tans = new StoreTransaction
                        {
                            storessId = item.Id,
                            purchasessId = item.PurchasesBillId,
                            salessId = sales1.Id,
                            quantity = remainingQuantity,


                        };
                        remainingQuantity = 0;


                        context.Add(tans);
                        context.Entry(item).State = EntityState.Modified; // Mark the entity as modified

                        context.SaveChanges();


                        break; // Exit the loop as we have fulfilled the sale quantity
                    }
                }

                context.SaveChanges();

                MessageBox.Show("تمت العملية بنجاح");
                BillsForms bills = new BillsForms();
                bills.Show()
;
                Hide();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            UpdateStore form = new UpdateStore();
            form.Show();
            Hide();
        }
    }
}
