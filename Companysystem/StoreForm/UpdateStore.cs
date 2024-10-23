using Companysystem.Dtos;
using Companysystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Companysystem.StoreForm
{
    public partial class UpdateStore : Form
    {
        public UpdateStore()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void UpdateStore_Load(object sender, EventArgs e)
        {


            using(var context = new StoreContext())
            {
                

                var data = context.Stores
                      .Include(p => p.PurchasesBill)
                      .Select(p => new StoreDto
                      {
                          month = p.PurchasesBill.Date.Month .ToString(),
                          Date = p.PurchasesBill.Date,
                          Item = p.PurchasesBill.Item.Name,
                          BillNumber = p.PurchasesBill.Id,
                          Supplier = p.PurchasesBill.Supplier.Name,
                          PricefromBill = p.PurchasesBill.Price,
                          Price = p.price,
                          BeginingStore =p.BeginingStore,
                          incoming = p.incoming,
                          outgoing = p.outgoing,
                          EndingStore =p.EndingStore,
                          InventoryCost =  p.InventoryCost,

                      })
                      .ToList();

                dataGridView1.DataSource = data;


            }

        }
    }
}
