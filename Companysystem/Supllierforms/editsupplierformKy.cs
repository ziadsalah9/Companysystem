using Companysystem.Clientforms;
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
    public partial class editsupplierformKy : BaseForm
    {

        int id;
        public editsupplierformKy(int supplierid)
        {
            InitializeComponent();
            id = supplierid;
        }

        private void editsupplierformKy_Load(object sender, EventArgs e)
        {

            using (var context = new StoreContext())
            {

                var supplier = context.Suppliers.FirstOrDefault(p => p.Id == id);

                kryptonTextBox2.Text = supplier.Name;





            }
        }

            private void kryptonButton1_Click(object sender, EventArgs e)
        {

            using (var context = new StoreContext())
            {



                var supplier = context.Suppliers.FirstOrDefault(p => p.Id == id);
                supplier.Name = kryptonTextBox2.Text;
                context.SaveChanges();
                SupplierformKy formKy = new();
                formKy.Show();
                Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SupplierformKy supplierformKy = new SupplierformKy();
            supplierformKy.Show();
                Hide();
        }
    }
}
