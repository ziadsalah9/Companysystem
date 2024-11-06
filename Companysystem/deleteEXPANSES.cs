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

namespace Companysystem
{
    public partial class deleteEXPANSES : Form
    {
        public deleteEXPANSES()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void btndelete_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new StoreContext())
            {

                var id = (int)numericUpDown1.Value;


                var remove = context.CostsAndExpensesModels.FirstOrDefault(x => x.Id == id);
                if (remove is not null)
                {

                    context.CostsAndExpensesModels.Remove(remove);
                    context.SaveChanges();

                    MessageBox.Show("تم الحذف بنجاح");
                }

                else
                {
                    MessageBox.Show("من فضلك قم بادخال رقم صحيح");
                }


            }
        }

        private void deleteEXPANSES_Load(object sender, EventArgs e)
        {

        }
    }
}
