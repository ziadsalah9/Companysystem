namespace Companysystem.ItemsForms
{
    partial class editItemsFormKy
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
            kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ion__arrow_back;
            pictureBox1.Location = new Point(105, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // kryptonTextBox2
            // 
            kryptonTextBox2.Location = new Point(171, 245);
            kryptonTextBox2.Name = "kryptonTextBox2";
            kryptonTextBox2.RightToLeft = RightToLeft.Yes;
            kryptonTextBox2.Size = new Size(525, 39);
            kryptonTextBox2.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonTextBox2.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonTextBox2.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonTextBox2.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBox2.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBox2.StateCommon.Border.Rounding = 20F;
            kryptonTextBox2.StateCommon.Content.Color1 = Color.Black;
            kryptonTextBox2.StateCommon.Content.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonTextBox2.TabIndex = 46;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(568, 161);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(128, 40);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 45;
            kryptonLabel1.Values.Text = "اسم العميل";
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(171, 332);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButton1.Size = new Size(176, 51);
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 224);
            kryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(40, 50, 60);
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
            kryptonButton1.TabIndex = 44;
            kryptonButton1.Values.Text = "تعديل";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // editItemsFormKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(kryptonTextBox2);
            Controls.Add(kryptonLabel1);
            Controls.Add(kryptonButton1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Center;
            MaximumSize = new Size(818, 497);
            MinimumSize = new Size(818, 497);
            Name = "editItemsFormKy";
            Text = "تعديل الاصناف";
            TitleStyle = Krypton.Toolkit.KryptonFormTitleStyle.Modern;
            Load += editItemsFormKy_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}