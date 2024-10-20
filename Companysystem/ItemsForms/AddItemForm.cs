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
    public partial class AddItemForm : Form
    {
        public AddItemForm()
        {
            InitializeComponent();
        }



        private void addbtn_Click(object sender, EventArgs e)
        {
            using (var context = new StoreContext())
            {
                var data = new Item
                {
                    Name = itemnametxt.Text,
                };

                if (data != null)
                {
                    context.items.Add(data);
                    context.SaveChanges();
                    MessageBox.Show("تمت الاضافة بنجاح");
                    Itemsform itemsform = new Itemsform();
                    itemsform.Show();
                    Hide();

                }
                else
                {
                    MessageBox.Show("الصنف موجود من قبل");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Itemsform itemsform = new Itemsform();
            itemsform.Show();
            Hide();
        }
    }
}
