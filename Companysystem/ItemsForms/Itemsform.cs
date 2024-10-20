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

namespace Companysystem.ItemsForms
{
    public partial class Itemsform : Form
    {
        public Itemsform()
        {
            InitializeComponent();
        }

        private void Btnback_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        private void btnShowItem_Click(object sender, EventArgs e)
        {
            using (var context = new StoreContext())
            {

                var data = context.items.ToList();
                dataGridView1.DataSource = data;

            }
        }


        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            using (var context = new StoreContext())
            {

                var olditem = context.items.FirstOrDefault(p => p.Id == deleteitemnum.Value);

                if (olditem != null)
                {
                    context.items.Remove(olditem);
                    context.SaveChanges();
                    MessageBox.Show("تم الحذف بنجاح");

                    var data = context.clients.ToList();
                    dataGridView1.DataSource = data;
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

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            AddItemForm form = new AddItemForm();
            form.Show();
            Hide();
        }

        private void Itemsform_Load(object sender, EventArgs e)
        {
            using (var context = new StoreContext())
            {
                var data = context.items.ToList();
                dataGridView1.DataSource = data;
            }
        }
    }
}
