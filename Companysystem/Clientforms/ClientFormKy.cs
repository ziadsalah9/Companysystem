using Companysystem.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Jenga.Theme;

namespace Companysystem.Clientforms
{
    public partial class ClientFormKy : BaseForm
    {
        public ClientFormKy()
        {
            InitializeComponent();
            AdjustDataGridViewSettings();
        }

        private void AdjustDataGridViewSettings()
        {
            // Ensure text wraps in cells
            dv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Automatically adjust row height to fit text
            dv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Ensure text wraps in column headers
            dv.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Automatically adjust column width to fit text
            dv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Set the size of the DataGridView
            dv.Size = new Size(800, 400); // Adjust the size as needed

            // Set the size of the form
            this.Size = new Size(1000, 600); // Adjust the size as needed
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

        private void ClientFormKy_Load(object sender, EventArgs e)
        {
            using (var context = new StoreContext())
            {
                var data = context.clients.ToList();
                dv.DataSource = data;

                dv.Columns["Id"].HeaderText = "رقم العميل";
                dv.Columns["Name"].HeaderText = "الاسم";
                LoadData();
            }
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
                            EditClient(clientId);
                        }
                        else if (action == "حذف")
                        {
                            // Handle delete action
                            DeleteClient(clientId);
                            var client = context.clients.FirstOrDefault(p => p.Id == clientId);

                            if (client != null)
                            {
                                context.clients.Remove(client);
                                context.SaveChanges();
                                // Refresh the data grid view
                                dv.DataSource = context.clients.ToList();
                            }
                        }
                    }
                }
            }
        }

        private void EditClient(int clientId)
        {
            // Implement the edit functionality here
            MessageBox.Show($"Editing client with ID: {clientId}");
        }

        private void DeleteClient(int clientId)
        {
            // Implement the delete functionality here
            MessageBox.Show($"Deleting client with ID: {clientId}");
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            AddClientFormKy ky = new AddClientFormKy();
            ky.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            using (var context = new StoreContext())
            {
                var data = context.clients.Where(p => p.Name.Contains( kryptonTextBox2.Text)).ToList();
                if (data.Count() > 0)
                {
                    dv.DataSource = data;
                }
                else
                {
                    dv.DataSource = context.clients.ToList();
                }
            }
        }
    }
}
