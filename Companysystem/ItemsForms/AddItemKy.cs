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

namespace Companysystem.ItemsForms
{
    public partial class AddItemKy : BaseForm
    {
        public AddItemKy()
        {
            InitializeComponent();
        }

        private void AddItemKy_Load(object sender, EventArgs e)
        {

        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {


            using (var context = new StoreContext())
            {

                var data = new Item
                {
                    Name = kryptonTextBox2.Text,
                };
                string trimmedName = data.Name.Trim();

                if (data.Name != "ادخل الاسم" && !string.IsNullOrEmpty(trimmedName))
                {

                    context.items.Add(data);
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
