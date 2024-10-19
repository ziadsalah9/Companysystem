namespace Companysystem.SalesForms
{
    partial class SalesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dateTimePicker1 = new DateTimePicker();
            listclientsname = new ListBox();
            btnadd = new Button();
            label1 = new Label();
            label2 = new Label();
            quantitynum = new NumericUpDown();
            label3 = new Label();
            itemBindingSource = new BindingSource(components);
            listBox1 = new ListBox();
            label4 = new Label();
            txtprice = new Label();
            priceNum = new NumericUpDown();
            discountxt = new Label();
            discountnum = new NumericUpDown();
            label7 = new Label();
            notestxt = new Label();
            Commissiontxt = new Label();
            commisionnum = new NumericUpDown();
            noticestxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)quantitynum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)discountnum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)commisionnum).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(442, 44);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // listclientsname
            // 
            listclientsname.FormattingEnabled = true;
            listclientsname.Location = new Point(442, 77);
            listclientsname.Name = "listclientsname";
            listclientsname.Size = new Size(250, 104);
            listclientsname.TabIndex = 1;
            listclientsname.SelectedIndexChanged += listclientsname_SelectedIndexChanged;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(29, 412);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(94, 29);
            btnadd.TabIndex = 2;
            btnadd.Text = "أضافة";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(723, 42);
            label1.Name = "label1";
            label1.Size = new Size(65, 28);
            label1.TabIndex = 3;
            label1.Text = "التاريخ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(723, 111);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 4;
            label2.Text = "العميل";
            // 
            // quantitynum
            // 
            quantitynum.Location = new Point(442, 352);
            quantitynum.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            quantitynum.Name = "quantitynum";
            quantitynum.Size = new Size(250, 27);
            quantitynum.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(725, 352);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 6;
            label3.Text = "الكمية";
            // 
            // itemBindingSource
            // 
            itemBindingSource.DataSource = typeof(Models.Item);
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(442, 200);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(250, 104);
            listBox1.TabIndex = 7;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(723, 244);
            label4.Name = "label4";
            label4.Size = new Size(71, 28);
            label4.TabIndex = 8;
            label4.Text = "الصنف";
            // 
            // txtprice
            // 
            txtprice.AutoSize = true;
            txtprice.Font = new Font("Segoe UI", 12F);
            txtprice.ForeColor = Color.FromArgb(0, 0, 64);
            txtprice.Location = new Point(295, 44);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(61, 28);
            txtprice.TabIndex = 10;
            txtprice.Text = "السعر";
            // 
            // priceNum
            // 
            priceNum.Location = new Point(12, 44);
            priceNum.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            priceNum.Name = "priceNum";
            priceNum.Size = new Size(250, 27);
            priceNum.TabIndex = 9;
            // 
            // discountxt
            // 
            discountxt.AutoSize = true;
            discountxt.Font = new Font("Segoe UI", 12F);
            discountxt.ForeColor = Color.FromArgb(0, 0, 64);
            discountxt.Location = new Point(295, 141);
            discountxt.Name = "discountxt";
            discountxt.Size = new Size(68, 28);
            discountxt.TabIndex = 12;
            discountxt.Text = "الخصم";
            // 
            // discountnum
            // 
            discountnum.Location = new Point(12, 141);
            discountnum.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            discountnum.Name = "discountnum";
            discountnum.Size = new Size(250, 27);
            discountnum.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.FromArgb(0, 0, 64);
            label7.Location = new Point(295, 352);
            label7.Name = "label7";
            label7.Size = new Size(0, 28);
            label7.TabIndex = 14;
            // 
            // notestxt
            // 
            notestxt.AutoSize = true;
            notestxt.Font = new Font("Segoe UI", 12F);
            notestxt.ForeColor = Color.FromArgb(0, 0, 64);
            notestxt.Location = new Point(295, 347);
            notestxt.Name = "notestxt";
            notestxt.Size = new Size(100, 28);
            notestxt.TabIndex = 16;
            notestxt.Text = "الملاحظات";
            // 
            // Commissiontxt
            // 
            Commissiontxt.AutoSize = true;
            Commissiontxt.Font = new Font("Segoe UI", 12F);
            Commissiontxt.ForeColor = Color.FromArgb(0, 0, 64);
            Commissiontxt.Location = new Point(295, 248);
            Commissiontxt.Name = "Commissiontxt";
            Commissiontxt.Size = new Size(88, 28);
            Commissiontxt.TabIndex = 18;
            Commissiontxt.Text = "العمولات";
            // 
            // commisionnum
            // 
            commisionnum.Location = new Point(12, 249);
            commisionnum.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            commisionnum.Name = "commisionnum";
            commisionnum.Size = new Size(250, 27);
            commisionnum.TabIndex = 17;
            // 
            // noticestxt
            // 
            noticestxt.Location = new Point(12, 327);
            noticestxt.Multiline = true;
            noticestxt.Name = "noticestxt";
            noticestxt.Size = new Size(250, 65);
            noticestxt.TabIndex = 19;
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(noticestxt);
            Controls.Add(Commissiontxt);
            Controls.Add(commisionnum);
            Controls.Add(notestxt);
            Controls.Add(label7);
            Controls.Add(discountxt);
            Controls.Add(discountnum);
            Controls.Add(txtprice);
            Controls.Add(priceNum);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(quantitynum);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnadd);
            Controls.Add(listclientsname);
            Controls.Add(dateTimePicker1);
            Name = "SalesForm";
            Text = " ";
            Load += SalesForm_Load;
            ((System.ComponentModel.ISupportInitialize)quantitynum).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)discountnum).EndInit();
            ((System.ComponentModel.ISupportInitialize)commisionnum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private ListBox listclientsname;
        private Button btnadd;
        private Label label1;
        private Label label2;
        private NumericUpDown quantitynum;
        private Label label3;
        private BindingSource itemBindingSource;
        private ListBox listBox1;
        private Label label4;
        private Label txtprice;
        private NumericUpDown priceNum;
        private Label discountxt;
        private NumericUpDown discountnum;
        private Label label7;
        private Label notestxt;
        private Label Commissiontxt;
        private NumericUpDown commisionnum;
        private TextBox noticestxt;
    }
}