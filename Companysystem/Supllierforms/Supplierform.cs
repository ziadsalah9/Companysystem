using Companysystem.Migrations;
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

namespace Companysystem.Supllierforms
{
    public partial class Supplierform : Form
    {
        public Supplierform()
        {
            InitializeComponent();
        }

        private void btnaddsupplier_Click(object sender, EventArgs e)
        {
            ADDsupplierform addsupplier = new ADDsupplierform();
            addsupplier.Show();
            Hide();
        }

        private void btnshowsuppliers_Click(object sender, EventArgs e)
        {

            using (var context = new StoreContext())
            {

                var data = context.Suppliers.ToList();

                dataGridView1.DataSource = data;

            }

        }

        private void btnremovesup_Click(object sender, EventArgs e)
        {
            using (var context = new StoreContext())
            {




                var old = context.Suppliers.FirstOrDefault(p => p.Id == numericUpDown1.Value);
                if (old is not null)
                {
                    context.Suppliers.Remove(old);
                    context.SaveChanges();
                    MessageBox.Show("تم الحذف بنجاح");
                }
                else
                {
                    MessageBox.Show("من فضلك قم بادخال رقم صحيح");
                }

            }
        }
    }
}
