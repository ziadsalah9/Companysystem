using Companysystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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
            InitializeComponent(); this.StartPosition = FormStartPosition.CenterScreen;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            string title = "Error";


            if (string.IsNullOrWhiteSpace(byantxt.Text))
            {
                MessageBox.Show("من فضلك ادخل قيمة للبيان", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal statment = decimal.Parse(byantxt.Text);


            if (string.IsNullOrWhiteSpace(salariestxt.Text))
            {
                MessageBox.Show("من فضلك ادخل قيمة للراتب", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal salary = decimal.Parse(salariestxt.Text);



            if (string.IsNullOrWhiteSpace(rintstxt.Text))
            {
                MessageBox.Show("من فضلك ادخل قيمة للايجارات", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal rent = decimal.Parse(rintstxt.Text);

            if (string.IsNullOrWhiteSpace(internettxt.Text))
            {
                MessageBox.Show("من فضلك ادخل قيمة للتيلفون والنت", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal internetphone = decimal.Parse(internettxt.Text);

            if (string.IsNullOrWhiteSpace(wegtxt.Text))
            {
                MessageBox.Show("من فضلك ادخل قيمة للمياه والكهرباء والغاز", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal weg = decimal.Parse(wegtxt.Text);



            if (string.IsNullOrWhiteSpace(tamenattxt.Text))
            {
                MessageBox.Show("من فضلك ادخل قيمة للتأمينات", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal insurance = decimal.Parse(tamenattxt.Text);


            if (string.IsNullOrWhiteSpace(carstxt.Text))
            {
                MessageBox.Show("من فضلك ادخل قيمة للسيارت", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal cars = decimal.Parse(carstxt.Text);

          



            if (string.IsNullOrWhiteSpace(baryedtxt.Text))
            {
                MessageBox.Show("من فضلك ادخل قيمة للبريد", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal mail = decimal.Parse(baryedtxt.Text);



      

            decimal other = othernum.Value;

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

            PlaySuccessSound();
            string message = "تمت العملية بنجاح!";
            string tittle = "نجاح";
            MessageBox.Show(message, tittle, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void PlaySuccessSound()
        {
            // تأكد من أن مسار الملف الصوتي صحيح
            string soundFilePath = @"C:\path\to\your\soundfile.wav";
            SoundPlayer player = new SoundPlayer(soundFilePath);
            player.Play();
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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
