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
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Companysystem
{
    public partial class CostsAndExpenses : Form
    {
        public CostsAndExpenses()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            decimal salary = decimal.Parse(salariestxt.Text);
            decimal cars = decimal.Parse(carstxt.Text);
            decimal weg = decimal.Parse(wegtxt.Text);
            decimal rent = decimal.Parse(rintstxt.Text);
            decimal insurance = decimal.Parse(tamenattxt.Text);
            decimal mail = decimal.Parse(baryedtxt.Text);
            decimal statment = decimal.Parse(byantxt.Text);
            decimal internetphone = decimal.Parse(internettxt.Text);
            decimal other = decimal.Parse(othertxt.Text);



            using (var context = new StoreContext())
            {
                var values = new CostsAndExpensesModel
                {
                    Date = date,
                    Salaries = salary,
                    Cars = cars,
                    Insurance = insurance,
                    Mails = mail,
                    others = other,
                    Statment = statment,
                    PhoneandInternet = internetphone,
                    Rints = rent,
                    WaterElectericityGas = weg,
                    Totalcost = salary + cars + weg + rent + insurance + mail + statment + internetphone + other,



                };

                context.CostsAndExpensesModels.Add(values);
                context.SaveChanges();
            }

            MessageBox.Show(" تمت الاضافة بنجاح ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowExpensesandcosts sh = new ShowExpensesandcosts();

            sh.Show();
            Hide();


        }

        private void CostsAndExpenses_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnTotal_Click(object sender, EventArgs e)
        {
            using (var context = new StoreContext())
            {

                var data = context.CostsAndExpensesModels.Sum(p => p.Totalcost);
                total.Text = data.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deleteEXPANSES dx = new deleteEXPANSES();
            dx.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnalysisCostsInYear dx = new AnalysisCostsInYear();
            dx.Show();
            Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }
    }
}
