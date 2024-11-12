using Companysystem.Clientforms;
using Companysystem.ItemsForms;
using Companysystem.PurchasesBillsForm;
using Companysystem.SalesForms;
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

namespace Companysystem
{
    public partial class HomeForm : BaseForm
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            HomeForm f = new HomeForm();
            f.Show();
            Hide();
        }


        private void button10_Click(object sender, EventArgs e)
        {
            SalesBillsFormKy ky = new();
            ky.Show();
            Hide();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {

            PurchasesBillSormKy ky = new PurchasesBillSormKy();
            ky.Show();
            Hide();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            CostsAndExpensesKy ky = new CostsAndExpensesKy();
            ky.Show();
            Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            SupplierformKy ky = new SupplierformKy();
            ky.Show();
            Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ClientFormKy ky = new();
            ky.Show();
            Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            clieFormKy ky = new clieFormKy();
            ky.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StoreForm.StoreFormKy ky = new StoreForm.StoreFormKy();
            ky.Show();
            Hide();
        }
    }
}
