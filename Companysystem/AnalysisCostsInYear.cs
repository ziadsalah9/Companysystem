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
    public partial class AnalysisCostsInYear : Form
    {
        private StoreContext context;
        public AnalysisCostsInYear()
        {
            InitializeComponent();
            context = new StoreContext();
        }

        private void AnalysisCostsInYear_Load(object sender, EventArgs e)
        {

            





        }

        private void btnsearch_Click(object sender, EventArgs e)
        {


            var data = context.CostsAndExpensesModels.Where(p => p.Date.Year == (int)analysisnumeric.Value).ToList();
            if (data.Count()>0)
            {
                analysisdgv.DataSource = data;


                analysisdgv.Columns["statment"].HeaderText = "البيان";
                analysisdgv.Columns["Insurance"].HeaderText = "تأمينات";
                analysisdgv.Columns["Rints"].HeaderText = "الايجارات";
                analysisdgv.Columns["Salaries"].HeaderText = "الرواتب";
                analysisdgv.Columns["Mails"].HeaderText = "البريد";
                analysisdgv.Columns["Cars"].HeaderText = "السيارات";
                analysisdgv.Columns["WaterElectericityGas"].HeaderText = "مياه وكهرباء وغاز";
                analysisdgv.Columns["Date"].HeaderText = "التاريخ";
                analysisdgv.Columns["others"].HeaderText = "اخرى";
                analysisdgv.Columns["Totalcost"].HeaderText = "الاجمالى";
                analysisdgv.Columns["PhoneandInternet"].HeaderText = "تليفون ونت";
            }
            else
            {
                analysisdgv.DataSource=0;
                MessageBox.Show("لا يوجد بيانات");
            }
        }
    }
}
