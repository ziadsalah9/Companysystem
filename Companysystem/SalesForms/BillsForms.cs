﻿using AutoMapper;
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
        private readonly IMapper _mapper;

        //public BillsForms()
        //{



        //}
        public BillsForms(IMapper mapper)
        {
            InitializeComponent();

            _mapper = mapper;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SalesForm s = new SalesForm();
            s.Show();
            Hide();
        }

        private void BillsForms_Load(object sender, EventArgs e)
        {
            using (var context = new StoreContext())
            {

                var result = context.Salesd.Include(p => p.Client).Include(p => p.Item).ToList();

               // Map the result to SalesDto
               var data = _mapper.Map<IEnumerable<SalesDto>>(result);

              //  Bind the mapped data to the DataGridView
                ShowBilldv.DataSource = data.ToList();

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