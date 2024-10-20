using AutoMapper;
using Companysystem.Clientforms;
using Companysystem.Models;
using Companysystem.PurchasesBillsForm;
using Companysystem.SalesForms;
using Companysystem.Supllierforms;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Companysystem
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }







        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClientForm client = new ClientForm();
            client.Show();
            Hide();


        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            BillsForms s = new BillsForms();
            s.Show();
            Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ItemsForms.Itemsform itform = new ItemsForms.Itemsform();
            itform.Show();
            Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            CostsAndExpenses c = new CostsAndExpenses();
            c.Show();
            Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var sup = new Supplierform();
            sup.Show();
            Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PurchsesBillForm purchsesBillForm = new PurchsesBillForm();
            purchsesBillForm.Show();
            Hide();

        }
    }
}
