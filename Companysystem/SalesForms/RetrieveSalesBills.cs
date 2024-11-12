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

namespace Companysystem.SalesForms
{
    public partial class RetrieveSalesBills : BaseForm
    {
        public RetrieveSalesBills()
        {
            InitializeComponent();
        }

        private void RetrieveSalesBills_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SalesBillsFormKy salesBillsFormKy = new SalesBillsFormKy();
            salesBillsFormKy.Show();
            Hide();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            using (var context = new StoreContext())
            {

            }
        }
    }
}
