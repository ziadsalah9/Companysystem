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
    public partial class ADDsupplierform : Form
    {
        public ADDsupplierform()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {

            using (var context = new StoreContext())
            {

                var data = new Supplier
                {
                    Name = supnametxt.Text,
                };

                context.Suppliers.Add(data);
                context.SaveChanges();
                MessageBox.Show("تمت الاضافة بنجاح");

                Supplierform supplierform = new Supplierform();
                supplierform.Show();
                Hide();

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Supplierform form = new Supplierform();
            form.Show();
            Hide();
        }
    }
}
