namespace Companysystem.SalesForms
{
    partial class AddBillsSalesForm
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
            label5 = new Label();
            Commissiontxt = new Label();
            commissionsnum = new NumericUpDown();
            label7 = new Label();
            discountxt = new Label();
            discountnum = new NumericUpDown();
            txtprice = new Label();
            priceNum = new NumericUpDown();
            label4 = new Label();
            listitemsname = new ListBox();
            label3 = new Label();
            label2 = new Label();
            btnadd = new Button();
            listclientsname = new ListBox();
            dateTimePicker1 = new DateTimePicker();
            itemBindingSource = new BindingSource(components);
            quantitynum = new NumericUpDown();
            label1 = new Label();
            noticestxt = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)commissionsnum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)discountnum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quantitynum).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(314, 297);
            label5.Name = "label5";
            label5.Size = new Size(88, 28);
            label5.TabIndex = 61;
            label5.Text = "ملاحظات";
            // 
            // Commissiontxt
            // 
            Commissiontxt.AutoSize = true;
            Commissiontxt.Font = new Font("Segoe UI", 12F);
            Commissiontxt.ForeColor = Color.FromArgb(0, 0, 64);
            Commissiontxt.Location = new Point(314, 199);
            Commissiontxt.Name = "Commissiontxt";
            Commissiontxt.Size = new Size(88, 28);
            Commissiontxt.TabIndex = 59;
            Commissiontxt.Text = "العمولات";
            // 
            // commissionsnum
            // 
            commissionsnum.Location = new Point(31, 200);
            commissionsnum.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            commissionsnum.Name = "commissionsnum";
            commissionsnum.Size = new Size(250, 27);
            commissionsnum.TabIndex = 58;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.FromArgb(0, 0, 64);
            label7.Location = new Point(314, 316);
            label7.Name = "label7";
            label7.Size = new Size(0, 28);
            label7.TabIndex = 57;
            // 
            // discountxt
            // 
            discountxt.AutoSize = true;
            discountxt.Font = new Font("Segoe UI", 12F);
            discountxt.ForeColor = Color.FromArgb(0, 0, 64);
            discountxt.Location = new Point(323, 92);
            discountxt.Name = "discountxt";
            discountxt.Size = new Size(68, 28);
            discountxt.TabIndex = 56;
            discountxt.Text = "الخصم";
            // 
            // discountnum
            // 
            discountnum.Location = new Point(34, 92);
            discountnum.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            discountnum.Name = "discountnum";
            discountnum.Size = new Size(250, 27);
            discountnum.TabIndex = 55;
            // 
            // txtprice
            // 
            txtprice.AutoSize = true;
            txtprice.Font = new Font("Segoe UI", 12F);
            txtprice.ForeColor = Color.FromArgb(0, 0, 64);
            txtprice.Location = new Point(323, 8);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(61, 28);
            txtprice.TabIndex = 54;
            txtprice.Text = "السعر";
            // 
            // priceNum
            // 
            priceNum.Location = new Point(34, 13);
            priceNum.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            priceNum.Name = "priceNum";
            priceNum.Size = new Size(250, 27);
            priceNum.TabIndex = 53;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(834, 209);
            label4.Name = "label4";
            label4.Size = new Size(71, 28);
            label4.TabIndex = 52;
            label4.Text = "الصنف";
            // 
            // listitemsname
            // 
            listitemsname.FormattingEnabled = true;
            listitemsname.Location = new Point(523, 164);
            listitemsname.Name = "listitemsname";
            listitemsname.Size = new Size(250, 104);
            listitemsname.TabIndex = 51;
            listitemsname.SelectedIndexChanged += listitemsname_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(836, 317);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 50;
            label3.Text = "الكمية";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(834, 76);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 48;
            label2.Text = "العميل";
            // 
            // btnadd
            // 
            btnadd.Location = new Point(31, 413);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(244, 54);
            btnadd.TabIndex = 46;
            btnadd.Text = "أضافة";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // listclientsname
            // 
            listclientsname.FormattingEnabled = true;
            listclientsname.Location = new Point(523, 41);
            listclientsname.Name = "listclientsname";
            listclientsname.Size = new Size(250, 104);
            listclientsname.TabIndex = 45;
            listclientsname.SelectedIndexChanged += listclientsname_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(523, 8);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 44;
            // 
            // itemBindingSource
            // 
            itemBindingSource.DataSource = typeof(Models.Item);
            // 
            // quantitynum
            // 
            quantitynum.Location = new Point(523, 316);
            quantitynum.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            quantitynum.Name = "quantitynum";
            quantitynum.Size = new Size(250, 27);
            quantitynum.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(834, 7);
            label1.Name = "label1";
            label1.Size = new Size(65, 28);
            label1.TabIndex = 47;
            label1.Text = "التاريخ";
            // 
            // noticestxt
            // 
            noticestxt.Location = new Point(31, 276);
            noticestxt.Multiline = true;
            noticestxt.Name = "noticestxt";
            noticestxt.Size = new Size(253, 86);
            noticestxt.TabIndex = 62;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // AddBillsSalesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 479);
            Controls.Add(noticestxt);
            Controls.Add(label5);
            Controls.Add(Commissiontxt);
            Controls.Add(commissionsnum);
            Controls.Add(label7);
            Controls.Add(discountxt);
            Controls.Add(discountnum);
            Controls.Add(txtprice);
            Controls.Add(priceNum);
            Controls.Add(label4);
            Controls.Add(listitemsname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnadd);
            Controls.Add(listclientsname);
            Controls.Add(dateTimePicker1);
            Controls.Add(quantitynum);
            Controls.Add(label1);
            Name = "AddBillsSalesForm";
            Text = "AddBillsSalesForm";
            Load += AddBillsSalesForm_Load;
            ((System.ComponentModel.ISupportInitialize)commissionsnum).EndInit();
            ((System.ComponentModel.ISupportInitialize)discountnum).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)quantitynum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label Commissiontxt;
        private NumericUpDown commissionsnum;
        private Label label7;
        private Label discountxt;
        private NumericUpDown discountnum;
        private Label txtprice;
        private NumericUpDown priceNum;
        private Label label4;
        private ListBox listitemsname;
        private Label label3;
        private Label label2;
        private Button btnadd;
        private ListBox listclientsname;
        private DateTimePicker dateTimePicker1;
        private BindingSource itemBindingSource;
        private NumericUpDown quantitynum;
        private Label label1;
        private TextBox noticestxt;
        private ContextMenuStrip contextMenuStrip1;
    }
}