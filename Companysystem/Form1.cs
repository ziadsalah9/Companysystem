using AutoMapper;
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





     

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClientForm client = new ClientForm();
            client.Show();
            Hide();


        }
        private readonly IMapper mapper;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            BillsForms s = new BillsForms( mapper);
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
    }
}
