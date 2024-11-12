using Companysystem.Models;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Companysystem.PurchasesBillsForm
{
    public partial class retriveinvoice : BaseForm
    {
        public retriveinvoice()
        {
            InitializeComponent();
        }

        private void retriveinvoice_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {


            using (var context = new StoreContext())
            {

                var data = context.Purchases.FirstOrDefault(p => p.Id == kryptondelete.Value);
                if (data != null)
                {

                    var old = context.Stores.FirstOrDefault(p => p.PurchasesBillId == data.Id);
                    old.incoming += (data.quantity * -1);
                    old.EndingStore += (data.quantity * -1);
                    old.InventoryCost += ((data.quantity * -1) * (old.priceUnit));

                    data.isRetrived = true;


                    context.SaveChanges();
                    string message = "تمت العملية بنجاح!";
                    string tittle = "نجاح";
                    MessageBox.Show(message, tittle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    PurchasesBillSormKy ku = new PurchasesBillSormKy();
                    ku.Show();
                    Hide();

                }
                else
                {
                    MessageBox.Show("لا توجد فاتورة بهذا الرقم ");
                }
            }
        }

        private void kryptondelete_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PurchasesBillSormKy ku = new PurchasesBillSormKy();
            ku.Show();
            Hide();
        }
    }
}
