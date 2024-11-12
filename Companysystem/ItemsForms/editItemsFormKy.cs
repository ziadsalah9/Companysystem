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

namespace Companysystem.ItemsForms
{
    public partial class editItemsFormKy : BaseForm
    {
        int id;
        public editItemsFormKy(int clientid)
        {
            InitializeComponent();
            id = clientid;
        }

        private void editItemsFormKy_Load(object sender, EventArgs e)
        {
            using (var context = new StoreContext())
            {

                var client = context.items.FirstOrDefault(p => p.Id == id);

                kryptonTextBox2.Text = client.Name;



            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            using (var context = new StoreContext())
            {



                var item = context.items.FirstOrDefault(p => p.Id == id);
                item.Name = kryptonTextBox2.Text;
                context.SaveChanges();
                clieFormKy formKy = new();
                formKy.Show();
                Hide();
            }
        }
    }
}
