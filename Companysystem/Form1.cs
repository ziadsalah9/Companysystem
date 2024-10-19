using Companysystem.Clientforms;
using Companysystem.Models;
using Companysystem.SalesForms;
using System;

namespace Companysystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string firstName = EmpNameTxt.Text;


            // Create a new Employee object
            Item newItem = new Item
            {
                Name = firstName,
            };

            // Add the new employee to the database or list
            using (var context = new StoreContext())
            {
                context.items.Add(newItem);
                context.SaveChanges();
            }

            MessageBox.Show("??? ??????? ????? ");
        }

        private void Next_Click(object sender, EventArgs e)
        {
            CostsAndExpenses c = new CostsAndExpenses();
            c.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClientForm client = new ClientForm();
            client.Show();
            Hide();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SalesForm s = new SalesForm();
            s.Show();
            Hide();
        }
    }
}
