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
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void btnshowclients_Click(object sender, EventArgs e)
        {
            using (var context = new StoreContext())
            {
                var data = context.clients.ToList();
                dataGridView1.DataSource = data;

            }
        }

        private void btnaddclient_Click(object sender, EventArgs e)
        {

        }

        private void btnaddclient_Click_1(object sender, EventArgs e)
        {
            AddClientForm addclient = new AddClientForm();
            addclient.Show();
            Hide();
        }

        private void btnremoveclient_Click(object sender, EventArgs e)
        {
            using (var context = new StoreContext())
            {




                var old = context.clients.FirstOrDefault(p => p.Id == numericUpDown1.Value);
                if (old is not null)
                {
                    context.clients.Remove(old);
                    context.SaveChanges();
                    MessageBox.Show("تم الحذف بنجاح");
                }
                else
                {
                    MessageBox.Show("من فضلك قم بادخال رقم صحيح");
                }

            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
