using AutoMapper;
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

namespace Companysystem.SalesForms
{
    public partial class BillsForms : Form
    {

        //public BillsForms()
        //{



        //}
        public BillsForms()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddBillsSalesForm s = new AddBillsSalesForm();
            s.Show();
            Hide();
        }

        private void BillsForms_Load(object sender, EventArgs e)
        {
            using (var context = new StoreContext())
            {

                //var result = context.Salesd.Include(p => p.Client).Include(p => p.Item).ToList();

                // Map the result to SalesDto
                //  var data = _mapper.Map<IEnumerable<SalesDto>>(result);

             //   var data = context.Salesd.ToList();
                var dataa= context.Salesd
                         .Include(p => p.Client).Include(p=>p.Item)
                         .Select(p => new SalesDto
                         {
                             quantity = p.quantity,
                             Price = p.Price,
                             Date = p.Date,
                             Client = p.Client.Name,
                             clientID = p.Client.Id,
                             deduct = p.deduct,
                             Commissions = p.Commissions,
                             month = p.month,
                             NetPriceValue = p.NetPriceValue,
                             Notes = p.Notes,
                             Id = p.Id,
                             Item = p.Item.Name,
                             priceValue = p.priceValue,
                             ItemfkId = p.ItemfkId
                         })
                         .ToList();

                //  Bind the mapped data to the DataGridView
                ShowBilldv.DataSource = dataa.ToList();

                ShowBilldv.Columns["Id"].HeaderText = "ID";
                ShowBilldv.Columns["month"].HeaderText = "الشهر";
                ShowBilldv.Columns["Date"].HeaderText ="التاريخ";
                ShowBilldv.Columns["Client"].HeaderText = "العميل";
                ShowBilldv.Columns["clientID"].HeaderText = "رقم العميل";
                ShowBilldv.Columns["item"].HeaderText = "الصنف";
                ShowBilldv.Columns["itemfkid"].HeaderText = "رقم الصنف";
                ShowBilldv.Columns["quantity"].HeaderText = "الكمية";
                ShowBilldv.Columns["price"].HeaderText = "السعر";
                ShowBilldv.Columns["priceValue"].HeaderText = "القيمة";
                ShowBilldv.Columns["deduct"].HeaderText = "الخصم";
                ShowBilldv.Columns["Commissions"].HeaderText = "العمولات";
                ShowBilldv.Columns["NetPriceValue"].HeaderText = "صافى القيمة";
                ShowBilldv.Columns["Notes"].HeaderText = "الملاحظات";







            }
        }
    }
}
