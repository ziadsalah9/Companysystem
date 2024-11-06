using Companysystem.Models;
using Companysystem.Supllierforms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Companysystem.Clientforms
{
    public partial class AddClientFormKy : BaseForm
    {
        public AddClientFormKy()
        {
            InitializeComponent();
        }

        private void AddClientFormKy_Load(object sender, EventArgs e)
        {

        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {


            using (var context = new StoreContext())
            {
                var data = new Client
                {
                    Name = kryptonTextBox2.Text,
                };

                context.clients.Add(data);
                context.SaveChanges();
                string message = "تمت العملية بنجاح!";
                string tittle = "نجاح";
                MessageBox.Show(message, tittle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClientFormKy supplierform = new ();
                supplierform.Show();
                Hide();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClientFormKy ky = new ClientFormKy();
            ky.Show();
            Hide();
        }
    }
}

