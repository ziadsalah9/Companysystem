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
    public partial class ClientForm : BaseForm
    {
        Responsive ResponsiveObj;

        public ClientForm()
        {
            InitializeComponent();
            //ResponsiveObj = new Responsive(Screen.PrimaryScreen.Bounds);
            //ResponsiveObj.SetMultiplicationFactor();
            this.StartPosition = FormStartPosition.CenterScreen;


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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

            //Width = ResponsiveObj.GetMetrics(Width, "Width");           // Form width and height set up.
            //Height = ResponsiveObj.GetMetrics(Height, "Height");
            //Left = Screen.GetBounds(this).Width / 2 - Width / 2;        // Form centering.
            //Top = Screen.GetBounds(this).Height / 2 - Height / 2 - 30;  // 30 is a calibration factor.

            //foreach (Control Ctl in this.Controls)
            //{
            //    Ctl.Font = new Font(FontFamily.GenericSansSerif,
            //               ResponsiveObj.GetMetrics((int)Ctl.Font.Size), FontStyle.Regular);
            //    Ctl.Width = ResponsiveObj.GetMetrics(Ctl.Width, "Width");
            //    Ctl.Height = ResponsiveObj.GetMetrics(Ctl.Height, "Height");
            //    Ctl.Top = ResponsiveObj.GetMetrics(Ctl.Top, "Top");
            //    Ctl.Left = ResponsiveObj.GetMetrics(Ctl.Left, "Left");
            //}
            using (var context = new StoreContext())
            {

                var data = context.clients.ToList();
                dataGridView1.DataSource = data;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
