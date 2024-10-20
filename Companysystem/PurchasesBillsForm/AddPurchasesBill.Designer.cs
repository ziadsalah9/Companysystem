namespace Companysystem.PurchasesBillsForm
{
    partial class AddPurchasesBill
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
            Commissiontxt = new Label();
            transportandshippingnum = new NumericUpDown();
            label7 = new Label();
            discountxt = new Label();
            discountnum = new NumericUpDown();
            txtprice = new Label();
            priceNum = new NumericUpDown();
            label4 = new Label();
            itemBindingSource = new BindingSource(components);
            listitemsname = new ListBox();
            label3 = new Label();
            quantitynum = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            btnadd = new Button();
            listsuppliersname = new ListBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            CustomsNum = new NumericUpDown();
            label6 = new Label();
            OtherNum = new NumericUpDown();
            label8 = new Label();
            unitnum = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)transportandshippingnum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)discountnum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quantitynum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomsNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OtherNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)unitnum).BeginInit();
            SuspendLayout();
            // 
            // Commissiontxt
            // 
            Commissiontxt.AutoSize = true;
            Commissiontxt.Font = new Font("Segoe UI", 12F);
            Commissiontxt.ForeColor = Color.FromArgb(0, 0, 64);
            Commissiontxt.Location = new Point(283, 179);
            Commissiontxt.Name = "Commissiontxt";
            Commissiontxt.Size = new Size(99, 28);
            Commissiontxt.TabIndex = 36;
            Commissiontxt.Text = "نقل وشحن";
            // 
            // transportandshippingnum
            // 
            transportandshippingnum.Location = new Point(9, 184);
            transportandshippingnum.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            transportandshippingnum.Name = "transportandshippingnum";
            transportandshippingnum.Size = new Size(250, 27);
            transportandshippingnum.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.FromArgb(0, 0, 64);
            label7.Location = new Point(292, 336);
            label7.Name = "label7";
            label7.Size = new Size(0, 28);
            label7.TabIndex = 33;
            // 
            // discountxt
            // 
            discountxt.AutoSize = true;
            discountxt.Font = new Font("Segoe UI", 12F);
            discountxt.ForeColor = Color.FromArgb(0, 0, 64);
            discountxt.Location = new Point(292, 91);
            discountxt.Name = "discountxt";
            discountxt.Size = new Size(68, 28);
            discountxt.TabIndex = 32;
            discountxt.Text = "الخصم";
            // 
            // discountnum
            // 
            discountnum.Location = new Point(9, 96);
            discountnum.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            discountnum.Name = "discountnum";
            discountnum.Size = new Size(250, 27);
            discountnum.TabIndex = 31;
            // 
            // txtprice
            // 
            txtprice.AutoSize = true;
            txtprice.Font = new Font("Segoe UI", 12F);
            txtprice.ForeColor = Color.FromArgb(0, 0, 64);
            txtprice.Location = new Point(292, 28);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(61, 28);
            txtprice.TabIndex = 30;
            txtprice.Text = "السعر";
            // 
            // priceNum
            // 
            priceNum.Location = new Point(12, 31);
            priceNum.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            priceNum.Name = "priceNum";
            priceNum.Size = new Size(250, 27);
            priceNum.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(947, 229);
            label4.Name = "label4";
            label4.Size = new Size(71, 28);
            label4.TabIndex = 28;
            label4.Text = "الصنف";
            // 
            // itemBindingSource
            // 
            itemBindingSource.DataSource = typeof(Models.Item);
            // 
            // listitemsname
            // 
            listitemsname.FormattingEnabled = true;
            listitemsname.Location = new Point(636, 184);
            listitemsname.Name = "listitemsname";
            listitemsname.Size = new Size(250, 104);
            listitemsname.TabIndex = 27;
            listitemsname.SelectedIndexChanged += listitemsname_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(949, 337);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 26;
            label3.Text = "الكمية";
            // 
            // quantitynum
            // 
            quantitynum.Location = new Point(636, 336);
            quantitynum.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            quantitynum.Name = "quantitynum";
            quantitynum.Size = new Size(250, 27);
            quantitynum.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(947, 96);
            label2.Name = "label2";
            label2.Size = new Size(62, 28);
            label2.TabIndex = 24;
            label2.Text = "المورد";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(947, 27);
            label1.Name = "label1";
            label1.Size = new Size(65, 28);
            label1.TabIndex = 23;
            label1.Text = "التاريخ";
            // 
            // btnadd
            // 
            btnadd.Location = new Point(26, 409);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(244, 54);
            btnadd.TabIndex = 22;
            btnadd.Text = "أضافة";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // listsuppliersname
            // 
            listsuppliersname.FormattingEnabled = true;
            listsuppliersname.Location = new Point(636, 61);
            listsuppliersname.Name = "listsuppliersname";
            listsuppliersname.Size = new Size(250, 104);
            listsuppliersname.TabIndex = 21;
            listsuppliersname.SelectedIndexChanged += listsuppliersname_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(636, 28);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(292, 260);
            label5.Name = "label5";
            label5.Size = new Size(64, 28);
            label5.TabIndex = 39;
            label5.Text = "جمارك";
            // 
            // CustomsNum
            // 
            CustomsNum.Location = new Point(9, 261);
            CustomsNum.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            CustomsNum.Name = "CustomsNum";
            CustomsNum.Size = new Size(250, 27);
            CustomsNum.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.FromArgb(0, 0, 64);
            label6.Location = new Point(292, 340);
            label6.Name = "label6";
            label6.Size = new Size(50, 28);
            label6.TabIndex = 41;
            label6.Text = "أخرى";
            // 
            // OtherNum
            // 
            OtherNum.Location = new Point(9, 341);
            OtherNum.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            OtherNum.Name = "OtherNum";
            OtherNum.Size = new Size(250, 27);
            OtherNum.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = Color.FromArgb(0, 0, 64);
            label8.Location = new Point(903, 407);
            label8.Name = "label8";
            label8.Size = new Size(115, 28);
            label8.TabIndex = 43;
            label8.Text = "تكلفة الوحدة";
            // 
            // unitnum
            // 
            unitnum.Location = new Point(636, 409);
            unitnum.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            unitnum.Name = "unitnum";
            unitnum.Size = new Size(250, 27);
            unitnum.TabIndex = 42;
            // 
            // AddPurchasesBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 482);
            Controls.Add(label8);
            Controls.Add(unitnum);
            Controls.Add(label6);
            Controls.Add(OtherNum);
            Controls.Add(label5);
            Controls.Add(CustomsNum);
            Controls.Add(Commissiontxt);
            Controls.Add(transportandshippingnum);
            Controls.Add(label7);
            Controls.Add(discountxt);
            Controls.Add(discountnum);
            Controls.Add(txtprice);
            Controls.Add(priceNum);
            Controls.Add(label4);
            Controls.Add(listitemsname);
            Controls.Add(label3);
            Controls.Add(quantitynum);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnadd);
            Controls.Add(listsuppliersname);
            Controls.Add(dateTimePicker1);
            Name = "AddPurchasesBill";
            Text = "AddPurchasesBill";
            Load += AddPurchasesBill_Load;
            ((System.ComponentModel.ISupportInitialize)transportandshippingnum).EndInit();
            ((System.ComponentModel.ISupportInitialize)discountnum).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)quantitynum).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomsNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)OtherNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)unitnum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Commissiontxt;
        private NumericUpDown transportandshippingnum;
        private Label label7;
        private Label discountxt;
        private NumericUpDown discountnum;
        private Label txtprice;
        private NumericUpDown priceNum;
        private Label label4;
        private BindingSource itemBindingSource;
        private ListBox listitemsname;
        private Label label3;
        private NumericUpDown quantitynum;
        private Label label2;
        private Label label1;
        private Button btnadd;
        private ListBox listsuppliersname;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private NumericUpDown CustomsNum;
        private Label label6;
        private NumericUpDown OtherNum;
        private Label label8;
        private NumericUpDown unitnum;
    }
}