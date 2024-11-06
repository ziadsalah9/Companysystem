using AutoMapper;
using Companysystem.Clientforms;
using Companysystem.ItemsForms;
using Companysystem.Models;
using Companysystem.PurchasesBillsForm;
using Companysystem.SalesForms;
using Companysystem.StoreForm;
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
            this.StartPosition = FormStartPosition.CenterScreen;

        }







        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClientFormKy client = new ClientFormKy();
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
            AddItemKy itform = new ItemsForms.AddItemKy();
            itform.Show();
            Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            CostsAndExpensesKy c = new CostsAndExpensesKy();
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
            PurchasesBillSormKy purchsesBillForm = new ();
            purchsesBillForm.Show();
            Hide();

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void storeButton_Click(object sender, EventArgs e)
        {
            UpdateStore storeForm = new UpdateStore();
            storeForm.Show();
            Hide();

        }

        private void label8_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm();
            testForm.Show();
            Hide();
        }
    }
}
