using AutoMapper;
using Companysystem.Clientforms;
using Companysystem.Dtos;
using Companysystem.ItemsForms;
using Companysystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
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

        private readonly StoreContext context;
        public BillsForms()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            context = new StoreContext();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var clients = context.clients.ToList();
            var items = context.items.ToList();

            if (clients.Count() <= 0)
            {
                MessageBox.Show("لا يوجد عملاء, من فضلك قم باضافة عميل");
                AddClientForm f = new AddClientForm();
                f.Show();
                Hide();

            }

            else if (items.Count() <= 0)
            {
                MessageBox.Show("لا يوجد أصناف, من فضلك قم بالاضافة");
                AddItemForm af = new AddItemForm();
                af.Show();

                Hide();

            }
            else
            {

                AddBillsSalesForm s = new AddBillsSalesForm();
                s.Show();
                Hide();
            }
        }

        private void BillsForms_Load(object sender, EventArgs e)
        {
            using (var context = new StoreContext())
            {

                //var result = context.Salesd.Include(p => p.Client).Include(p => p.Item).ToList();

                // Map the result to SalesDto
                //  var data = _mapper.Map<IEnumerable<SalesDto>>(result);

                //   var data = context.Salesd.ToList();
                var dataa = context.Salesd
                         .Include(p => p.Client).Include(p => p.Item)
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

                ShowBilldv.Columns["Id"].HeaderText = "رقم الفاتورة";
                ShowBilldv.Columns["month"].HeaderText = "الشهر";
                ShowBilldv.Columns["Date"].HeaderText = "التاريخ";
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

        private void button1_Click(object sender, EventArgs e)
        {

            using (var context = new StoreContext())
            {




                var data = context.Salesd.Where(p=>p.Date.Year==Yeardd.Value)
                                      .Include(p => p.Client).Include(p => p.Item)
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

                if (data.Count()>0)
                {
                    ShowBilldv.DataSource = data;
                }

                else {
                    ShowBilldv.DataSource = data;

                    MessageBox.Show("لا يوجد بيانات فى هذه السنة");
                }
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


            
             
               
                Form1 form1 = new Form1();
                form1.Show();
                Hide();
            
        }
    }
}
