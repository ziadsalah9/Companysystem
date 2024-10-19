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
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            using (var context = new StoreContext())
            {


                //var data = context.clients.ToList();
                //foreach (var item in data)
                //{
                //    listclientsname.Items.Add(item.Name);

                //}
                var clients = context.clients.ToList();
                listclientsname.DataSource = clients;
                listclientsname.DisplayMember = "Name";
                listclientsname.ValueMember = "Id";

                var items = context.items.ToList();
                listBox1.DataSource = items;
                listBox1.DisplayMember = "Name";
                listBox1.ValueMember = "Id";


                listclientsname.SelectedIndexChanged += Listclientsname_SelectedIndexChanged;


            }
        }

        private void Listclientsname_SelectedIndexChanged(object? sender, EventArgs e)
        {


        }


        private void listclientsname_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new StoreContext())
            {
                // Ensure the selected value is cast to the correct type (assuming int)

               
                    int selectedId = (int)listclientsname.SelectedValue ;
                    int itemfk = (int)listBox1.SelectedValue;
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
                            quantity =(int) quantitynum.Value,
                            Commissions = commisionnum.Value,
                            deduct = discountnum.Value,
                           Notes = noticestxt.Text,
                           Price = priceNum.Value,
                            priceValue = quantitynum.Value * priceNum.Value,
                            NetPriceValue = (quantitynum.Value * priceNum.Value)-(discountnum.Value +commisionnum.Value),

                            
                        };

                        context.Salesd.Add(sale);
                        context.SaveChanges();
                    }
                
             
                
               
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
