namespace Companysystem.SalesForms
{
    partial class AddSalesBillsFormKy
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
            pictureBox1 = new PictureBox();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonDate = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonquantity = new Krypton.Toolkit.KryptonNumericUpDown();
            kryptonprice = new Krypton.Toolkit.KryptonNumericUpDown();
            kryptondiscount = new Krypton.Toolkit.KryptonNumericUpDown();
            kryptoncommision = new Krypton.Toolkit.KryptonNumericUpDown();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonListitems = new Krypton.Toolkit.KryptonListBox();
            kryptonListclients = new Krypton.Toolkit.KryptonListBox();
            noticestxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ion__arrow_back;
            pictureBox1.Location = new Point(57, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 64;
            pictureBox1.TabStop = false;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(75, 654);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButton1.Size = new Size(480, 73);
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 224);
            kryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButton1.StateCommon.Back.ColorAngle = 45F;
            kryptonButton1.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 224);
            kryptonButton1.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButton1.StateCommon.Border.ColorAngle = 45F;
            kryptonButton1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton1.StateCommon.Border.Rounding = 20F;
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton1.TabIndex = 63;
            kryptonButton1.Values.Text = "اضافة";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // kryptonDate
            // 
            kryptonDate.Location = new Point(938, 84);
            kryptonDate.Name = "kryptonDate";
            kryptonDate.Size = new Size(264, 25);
            kryptonDate.TabIndex = 62;
            // 
            // kryptonquantity
            // 
            kryptonquantity.AllowDecimals = true;
            kryptonquantity.DecimalPlaces = 3;
            kryptonquantity.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            kryptonquantity.Location = new Point(938, 565);
            kryptonquantity.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            kryptonquantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            kryptonquantity.Name = "kryptonquantity";
            kryptonquantity.Size = new Size(273, 38);
            kryptonquantity.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonquantity.StateCommon.Border.Rounding = 20F;
            kryptonquantity.TabIndex = 61;
            kryptonquantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // kryptonprice
            // 
            kryptonprice.AllowDecimals = true;
            kryptonprice.DecimalPlaces = 3;
            kryptonprice.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            kryptonprice.Location = new Point(91, 77);
            kryptonprice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            kryptonprice.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            kryptonprice.Name = "kryptonprice";
            kryptonprice.Size = new Size(273, 38);
            kryptonprice.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonprice.StateCommon.Border.Rounding = 20F;
            kryptonprice.TabIndex = 59;
            kryptonprice.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // kryptondiscount
            // 
            kryptondiscount.AllowDecimals = true;
            kryptondiscount.DecimalPlaces = 3;
            kryptondiscount.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            kryptondiscount.Location = new Point(91, 190);
            kryptondiscount.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            kryptondiscount.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            kryptondiscount.Name = "kryptondiscount";
            kryptondiscount.Size = new Size(273, 38);
            kryptondiscount.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptondiscount.StateCommon.Border.Rounding = 20F;
            kryptondiscount.TabIndex = 58;
            kryptondiscount.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // kryptoncommision
            // 
            kryptoncommision.AllowDecimals = true;
            kryptoncommision.DecimalPlaces = 3;
            kryptoncommision.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            kryptoncommision.Location = new Point(91, 317);
            kryptoncommision.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            kryptoncommision.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            kryptoncommision.Name = "kryptoncommision";
            kryptoncommision.Size = new Size(273, 38);
            kryptoncommision.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptoncommision.StateCommon.Border.Rounding = 20F;
            kryptoncommision.TabIndex = 57;
            kryptoncommision.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Location = new Point(482, 445);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(115, 40);
            kryptonLabel6.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel6.TabIndex = 53;
            kryptonLabel6.Values.Text = "ملاحظات";
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Location = new Point(493, 190);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new Size(87, 40);
            kryptonLabel7.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel7.TabIndex = 52;
            kryptonLabel7.Values.Text = "الخصم";
            // 
            // kryptonLabel8
            // 
            kryptonLabel8.Location = new Point(501, 75);
            kryptonLabel8.Name = "kryptonLabel8";
            kryptonLabel8.Size = new Size(79, 40);
            kryptonLabel8.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel8.TabIndex = 51;
            kryptonLabel8.Values.Text = "السعر";
            // 
            // kryptonLabel9
            // 
            kryptonLabel9.Location = new Point(454, 315);
            kryptonLabel9.Name = "kryptonLabel9";
            kryptonLabel9.Size = new Size(111, 40);
            kryptonLabel9.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel9.TabIndex = 50;
            kryptonLabel9.Values.Text = "العمولات";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(1279, 559);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(78, 40);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel4.TabIndex = 48;
            kryptonLabel4.Values.Text = "الكمية";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(1265, 231);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(82, 40);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 47;
            kryptonLabel3.Values.Text = "العميل";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(1261, 69);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(89, 40);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 46;
            kryptonLabel2.Values.Text = "التاريخ";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(1265, 407);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(92, 40);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 45;
            kryptonLabel1.Values.Text = "الصنف";
            // 
            // kryptonListitems
            // 
            kryptonListitems.Location = new Point(938, 351);
            kryptonListitems.Name = "kryptonListitems";
            kryptonListitems.Size = new Size(264, 128);
            kryptonListitems.TabIndex = 44;
            kryptonListitems.SelectedIndexChanged += kryptonListitems_SelectedIndexChanged;
            // 
            // kryptonListclients
            // 
            kryptonListclients.Location = new Point(938, 171);
            kryptonListclients.Name = "kryptonListclients";
            kryptonListclients.Size = new Size(264, 128);
            kryptonListclients.TabIndex = 43;
            kryptonListclients.SelectedIndexChanged += kryptonListclients_SelectedIndexChanged;
            // 
            // noticestxt
            // 
            noticestxt.Location = new Point(91, 407);
            noticestxt.Multiline = true;
            noticestxt.Name = "noticestxt";
            noticestxt.Size = new Size(273, 159);
            noticestxt.TabIndex = 65;
            // 
            // AddSalesBillsFormKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1414, 751);
            Controls.Add(noticestxt);
            Controls.Add(pictureBox1);
            Controls.Add(kryptonButton1);
            Controls.Add(kryptonDate);
            Controls.Add(kryptonquantity);
            Controls.Add(kryptonprice);
            Controls.Add(kryptondiscount);
            Controls.Add(kryptoncommision);
            Controls.Add(kryptonLabel6);
            Controls.Add(kryptonLabel7);
            Controls.Add(kryptonLabel8);
            Controls.Add(kryptonLabel9);
            Controls.Add(kryptonLabel4);
            Controls.Add(kryptonLabel3);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonLabel1);
            Controls.Add(kryptonListitems);
            Controls.Add(kryptonListclients);
            FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Center;
            MaximumSize = new Size(1432, 798);
            MinimumSize = new Size(1432, 798);
            Name = "AddSalesBillsFormKy";
            Text = "اضافة فاتورة مبيعات";
            TitleStyle = Krypton.Toolkit.KryptonFormTitleStyle.Modern;
            Load += AddSalesBillsFormKy_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDate;
        private Krypton.Toolkit.KryptonNumericUpDown kryptonquantity;
        private Krypton.Toolkit.KryptonNumericUpDown kryptonprice;
        private Krypton.Toolkit.KryptonNumericUpDown kryptondiscount;
        private Krypton.Toolkit.KryptonNumericUpDown kryptoncommision;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonListBox kryptonListitems;
        private Krypton.Toolkit.KryptonListBox kryptonListclients;
        private TextBox noticestxt;
    }
}