﻿using Companysystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Companysystem.Clientforms
{
    public partial class AddClientForm : Krypton.Toolkit.KryptonForm
    {
        public AddClientForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // تعبير منتظم للتحقق من بداية رقم الهاتف
            string pattern = @"^(011|012|015|010)";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(phoneNumber);
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            using (var context = new StoreContext())
            {
                var name = clientnametxt.Text;
                //var clientno = clientnotxt.Text;

                //var check = context.clients.FirstOrDefault(p => p.ClientNo == clientno);


                //if (check != null || clientno.Length != 11 || !IsValidPhoneNumber(clientno))
                //{

                //    MessageBox.Show("من فضلك ادخل رقم صحيح مكون من 11 رقم وغير موجود من قبل");
                //}
                //else
                //{

                var data = new Client
                {
                    Name = name,
                    // ClientNo = Guid.NewGuid().ToString(),
                };

                context.clients.Add(data);
                context.SaveChanges();
                MessageBox.Show("تمت الاضافة بنجاح");

                ClientForm client = new ClientForm();
                client.Show();
                Hide();



            }
        }



        private void clientnametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClientForm form = new ClientForm();
            form.Show();
            Hide();
        }

        private void AddClientForm_Load(object sender, EventArgs e)
        {

        }
    }
}
