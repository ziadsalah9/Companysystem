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


            if (clients.Count()<=0)
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



                context.Salesd.Add(sale);
                context.SaveChanges();


                var billsfor = new BillsForms();
                billsfor.Show();
                Hide();

            }
        }
    }
}
