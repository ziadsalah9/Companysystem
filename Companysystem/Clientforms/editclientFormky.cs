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

namespace Companysystem.Clientforms
{
    public partial class editclientFormky : BaseForm
    {
        int id;
        public editclientFormky(int clientid)
        {
            InitializeComponent();
            id = clientid;
        }

        private void editclientFormky_Load(object sender, EventArgs e)
        {

            using (var context = new StoreContext())
            {

                var client = context.clients.FirstOrDefault(p => p.Id == id);

                kryptonTextBox2.Text = client.Name;



            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {


            using (var context = new StoreContext())
            {



                var client = context.clients.FirstOrDefault(p => p.Id == id);
                client.Name = kryptonTextBox2.Text;
                context.SaveChanges();
                ClientFormKy formKy = new();
                formKy.Show();
                Hide();
            }



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClientFormKy formKy = new();
            formKy.Show();
            Hide();
        }
    }
}
