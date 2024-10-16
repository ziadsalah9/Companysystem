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
    public partial class ShowExpensesandcosts : Form
    {
        public ShowExpensesandcosts()
        {
            InitializeComponent();
        }

        private void ShowExpensesandcosts_Load(object sender, EventArgs e)
        {


            using (var context = new StoreContext())
            {

                var data = context.CostsAndExpensesModels.ToList();

                dataGridViewCostsandexpans.DataSource = data;


                dataGridViewCostsandexpans.Columns["statment"].HeaderText = "البيان";
                dataGridViewCostsandexpans.Columns["Insurance"].HeaderText = "تأمينات";
                dataGridViewCostsandexpans.Columns["Rints"].HeaderText = "الايجارات";
                dataGridViewCostsandexpans.Columns["Salaries"].HeaderText = "الرواتب";
                dataGridViewCostsandexpans.Columns["Mails"].HeaderText = "البريد";
                dataGridViewCostsandexpans.Columns["Cars"].HeaderText = "السيارات";
                dataGridViewCostsandexpans.Columns["WaterElectericityGas"].HeaderText = "مياه وكهرباء وغاز";
                dataGridViewCostsandexpans.Columns["Date"].HeaderText = "التاريخ";
                dataGridViewCostsandexpans.Columns["others"].HeaderText = "اخرى";
                dataGridViewCostsandexpans.Columns["Totalcost"].HeaderText = "الاجمالى";
                dataGridViewCostsandexpans.Columns["PhoneandInternet"].HeaderText = "تليفون ونت";



            }
        }

        private void dataGridViewCostsandexpans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
