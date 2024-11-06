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

namespace Companysystem
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            //using (var context = new StoreContext())
            //{
            //    var records = context.Stores.OrderBy(r => r.Id).ToList();
            //    int sum = 0;

            //    foreach (var record in records)
            //    {
            //        sum += record.EndingStore;
            //        if (sum >= 13)
            //        {
            //            break;
            //        }
            //        context.Stores.Remove(record);
            //    }

            //    context.SaveChanges();

               // dataGridView1.DataSource = aggregatedQuantities.Select(q => new { EndingStore = q }).ToList();
            }
        }
   }
