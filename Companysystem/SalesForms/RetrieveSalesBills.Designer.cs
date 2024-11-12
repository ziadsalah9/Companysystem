namespace Companysystem.SalesForms
{
    partial class RetrieveSalesBills
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
            kryptondelete = new Krypton.Toolkit.KryptonNumericUpDown();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ion__arrow_back;
            pictureBox1.Location = new Point(53, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 69;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // kryptondelete
            // 
            kryptondelete.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            kryptondelete.Location = new Point(244, 300);
            kryptondelete.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            kryptondelete.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            kryptondelete.Name = "kryptondelete";
            kryptondelete.Size = new Size(549, 38);
            kryptondelete.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptondelete.StateCommon.Border.Rounding = 20F;
            kryptondelete.TabIndex = 68;
            kryptondelete.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(297, 166);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(426, 40);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 67;
            kryptonLabel1.Values.Text = "ادخل رقم الفاتورة التى تريد استرجاعها";
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(383, 423);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButton1.Size = new Size(244, 55);
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(255, 0, 60);
            kryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(255, 0, 60);
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
            kryptonButton1.TabIndex = 66;
            kryptonButton1.Values.Text = "حذف";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // RetrieveSalesBills
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 582);
            Controls.Add(pictureBox1);
            Controls.Add(kryptondelete);
            Controls.Add(kryptonLabel1);
            Controls.Add(kryptonButton1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Center;
            Name = "RetrieveSalesBills";
            Text = "استرجاع فاتورة مبيعات";
            TitleStyle = Krypton.Toolkit.KryptonFormTitleStyle.Modern;
            Load += RetrieveSalesBills_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonNumericUpDown kryptondelete;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}