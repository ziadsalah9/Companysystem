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
    public partial class SupplierformKy : BaseForm
    {
        public SupplierformKy()
        {
            InitializeComponent();
            // تأكد من تعيين WrapMode إلى DataGridViewTriState.True
            dv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // يمكنك أيضًا ضبط ارتفاع الصف تلقائيًا ليتناسب مع النص
            dv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            // تأكد من تعيين WrapMode إلى DataGridViewTriState.True لرؤوس الأعمدة
            dv.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // يمكنك أيضًا ضبط ارتفاع رؤوس الأعمدة تلقائيًا ليتناسب مع النص
            dv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void LoadData()
        {
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.HeaderText = "تعديل";
            editButton.Text = "تعديل";
            editButton.UseColumnTextForButtonValue = true;
            dv.Columns.Add(editButton);

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.HeaderText = "حذف";
            deleteButton.Text = "حذف";
            deleteButton.UseColumnTextForButtonValue = true;
            dv.Columns.Add(deleteButton);
        }
        private void SupplierformKy_Load(object sender, EventArgs e)
        {
            using (var context = new StoreContext())
            {
                var data = context.Suppliers.ToList();
                dv.DataSource = data;

                dv.Columns["Id"].HeaderText = "رقم المورد";
                dv.Columns["Name"].HeaderText = "الاسم";
                LoadData();
            }
        }

        private void EditClient(int clientId)
        {
            // Implement the edit functionality here
            MessageBox.Show($"Editing supplier with ID: {clientId}");
        }

        private void DeleteClient(int clientId)
        {
            // Implement the delete functionality here
            MessageBox.Show($"Deleting supplier with ID: {clientId}");
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            AddSupplierKy ky = new AddSupplierKy();
            ky.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (var context = new StoreContext())
            {
                var data = context.Suppliers.Where(p => p.Name.Contains(kryptonTextBox2.Text)).ToList();
                if (data.Count() > 0)
                {
                    dv.DataSource = data;
                }
                else
                {
                    dv.DataSource = context.Suppliers.ToList();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HomeForm f = new();
            f.Show();
            Hide();
        }

        private void dv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var context = new StoreContext())
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Check if the clicked cell is a button cell
                    if (dv.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                    {
                        string action = dv.Columns[e.ColumnIndex].HeaderText;
                        int clientId = (int)dv.Rows[e.RowIndex].Cells["Id"].Value;

                        if (action == "تعديل")
                        {
                            // Handle edit action
                            editsupplierformKy ky = new (clientId);
                            ky.Show();
                            Hide();
                        }
                        else if (action == "حذف")
                        {
                            // Handle delete action
                            DeleteClient(clientId);
                            var client = context.Suppliers.FirstOrDefault(p => p.Id == clientId);

                            if (client != null)
                            {
                                context.Suppliers.Remove(client);
                                context.SaveChanges();
                                // Refresh the data grid view
                                dv.DataSource = context.Suppliers.ToList();
                            }
                        }
                    }
                }
            }
        }
    }
}
