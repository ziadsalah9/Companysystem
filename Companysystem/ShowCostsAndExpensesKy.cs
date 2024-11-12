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
    public partial class ShowCostsAndExpensesKy : BaseForm
    {
        public ShowCostsAndExpensesKy()
        {
            InitializeComponent();
            // تأكد من تعيين WrapMode إلى DataGridViewTriState.True
            dv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // يمكنك أيضًا ضبط ارتفاع الصف تلقائيًا ليتناسب مع النص
            dv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            // تأكد من تعيين WrapMode إلى DataGridViewTriState.True لرؤوس الأعمدة
            dv.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // يمكنك أيضًا ضبط ارتفاع رؤوس الأعمدة تلقائيًا ليتناسب مع النص
            dv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void ShowCostsAndExpensesKy_Load(object sender, EventArgs e)
        {


            using (var context = new StoreContext())
            {

                var data = context.CostsAndExpensesModels.ToList();

                dv.DataSource = data;


                dv.Columns["statment"].HeaderText = "البيان";
                dv.Columns["Insurance"].HeaderText = "تأمينات";
                dv.Columns["Rints"].HeaderText = "الايجارات";
                dv.Columns["Salaries"].HeaderText = "الرواتب";
                dv.Columns["Mails"].HeaderText = "البريد";
                dv.Columns["Cars"].HeaderText = "السيارات";
                dv.Columns["WaterElectericityGas"].HeaderText = "مياه وكهرباء وغاز";
                dv.Columns["Date"].HeaderText = "التاريخ";
                dv.Columns["others"].HeaderText = "اخرى";
                dv.Columns["Totalcost"].HeaderText = "الاجمالى";
                dv.Columns["PhoneandInternet"].HeaderText = "تليفون ونت";



            }



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CostsAndExpensesKy ky = new();
            ky.Show();
            Hide();
        }

        private void dv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
