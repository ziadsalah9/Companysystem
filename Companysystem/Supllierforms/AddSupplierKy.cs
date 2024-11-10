using Companysystem.Models;
using Org.BouncyCastle.Security;
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
    public partial class AddSupplierKy : BaseForm
    {
        public AddSupplierKy()
        {
            InitializeComponent();
        }

        private void AddSupplierKy_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            using (var context = new StoreContext())
            {




                var data = new Supplier
                {
                    Name = kryptonTextBox2.Text,
                };
                string trimmedName = data.Name.Trim();

                if (data.Name!= "ادخل الاسم" && !string.IsNullOrEmpty(trimmedName))
                {

                    context.Suppliers.Add(data);
                    context.SaveChanges();
                    string message = "تمت العملية بنجاح!";
                    string tittle = "نجاح";

                    MessageBox.Show(message, tittle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                SupplierformKy supplierform = new ();
                supplierform.Show();
                Hide();

            }
        }
    }
}
