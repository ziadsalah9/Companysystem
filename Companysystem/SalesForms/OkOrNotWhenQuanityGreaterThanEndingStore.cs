using Companysystem.Models;
using Companysystem.StoreForm;
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
    public partial class OkOrNotWhenQuanityGreaterThanEndingStore : Form
    {
        Store store1;
        Sales sales1;
        public OkOrNotWhenQuanityGreaterThanEndingStore(int number, Sales sales, Store firstenterdinstore)
        {
            InitializeComponent();
            label2.Text = number.ToString();
            store1 = firstenterdinstore;
            sales1 = sales;

        }

        private void OkOrNotWhenQuanityGreaterThanEndingStore_Load(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (var context = new StoreContext())
            {


                if (label2.Text == "0")
                {
                    MessageBox.Show("لا يوجد هذا الصنف فى المخزن");

                    Form1 form = new Form1();
                    form.Show();
                    Hide();
                }

                context.Salesd.Add(sales1);
                // context.Stores.Add(store);
                context.Stores.Remove(store1);
                context.SaveChanges();
                MessageBox.Show("تمت العملية بنجاح");


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateStore form = new UpdateStore();
            form.Show();
            Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
