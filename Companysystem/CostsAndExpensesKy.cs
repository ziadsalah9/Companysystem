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

namespace Companysystem
{
    public partial class CostsAndExpensesKy : BaseForm
    {
        public CostsAndExpensesKy()
        {
            InitializeComponent();
        }

        private void CostsAndExpensesKy_Load(object sender, EventArgs e)
        {
            using (var context = new StoreContext())
            {

                // Calculate total cost for the current year
                var datayear = context.CostsAndExpensesModels.Where(p => p.Date.Year == DateTime.Now.Year).Sum(p => p.Totalcost);
                kryptonlabelyear.Text = datayear.ToString();

                // Calculate total cost for the current month
                var datamonth = context.CostsAndExpensesModels.Where(p => p.Date.Month == DateTime.Now.Month).Sum(p => p.Totalcost);
                kryptonLabelmonth.Text = datamonth.ToString(); // Use a different label for the month

                // Calculate total cost for the current day
                var dataday = context.CostsAndExpensesModels.Where(p => p.Date.Day == DateTime.Now.Day).Sum(p => p.Totalcost);
                kryptonLabelday.Text = dataday.ToString(); // Use a different label for the day

            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            DateTime date = kryptonDate.Value;
            string title = "Error";



            decimal statment = kryptonbayan.Value;



            decimal salary = kryptonrowateb.Value;



            decimal rent = kryptonrents.Value;


            decimal internetphone = kryptontelephone.Value;

            decimal weg = kryptonweg.Value;




            decimal insurance = kryptontamenat.Value;



            decimal cars = kryptoncayarat.Value;



            decimal mail = kryptonNumericbaryed.Value;





            decimal other = kryptonother.Value;

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

            // PlaySuccessSound();
            string message = "تمت العملية بنجاح!";
            string tittle = "نجاح";
            MessageBox.Show(message, tittle, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //private void PlaySuccessSound()
        //{
        //    تأكد من أن مسار الملف الصوتي صحيح
        //    string soundFilePath = @"C:\path\to\your\soundfile.wav";
        //    SoundPlayer player = new SoundPlayer(soundFilePath);
        //    player.Play();
        //}

        private void kryptonbayan_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            ShowCostsAndExpensesKy ky = new();
            ky.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomeForm f = new ();
            f.Show();
            Hide();
        }
    }
}

