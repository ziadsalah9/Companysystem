﻿namespace Companysystem.ItemsForms
{
    partial class clieFormKy
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
            dv = new Krypton.Toolkit.KryptonDataGridView();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            panel1 = new Panel();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            pictureBox1 = new PictureBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dv).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dv
            // 
            dv.AllowUserToAddRows = false;
            dv.AllowUserToDeleteRows = false;
            dv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dv.BorderStyle = BorderStyle.None;
            dv.ColumnHeadersHeight = 36;
            dv.Dock = DockStyle.Fill;
            dv.Location = new Point(0, 0);
            dv.Name = "dv";
            dv.ReadOnly = true;
            dv.RightToLeft = RightToLeft.Yes;
            dv.RowHeadersWidth = 51;
            dv.Size = new Size(748, 515);
            dv.StateCommon.Background.Color1 = Color.FromArgb(250, 252, 252);
            dv.StateCommon.Background.Color2 = Color.FromArgb(250, 252, 252);
            dv.StateCommon.Background.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Form;
            dv.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dv.StateCommon.DataCell.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dv.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(6, 174, 224);
            dv.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(8, 142, 254);
            dv.StateCommon.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dv.StateCommon.HeaderRow.Back.Color1 = Color.White;
            dv.StateCommon.HeaderRow.Back.Color2 = Color.White;
            dv.TabIndex = 0;
            dv.CellContentClick += dv_CellContentClick;
            // 
            // kryptonCustomPaletteBase1
            // 
            kryptonCustomPaletteBase1.BaseFont = new Font("Segoe UI", 9F);
            kryptonCustomPaletteBase1.BaseFontSize = 9F;
            kryptonCustomPaletteBase1.BasePaletteType = Krypton.Toolkit.BasePaletteType.Custom;
            kryptonCustomPaletteBase1.ThemeName = "";
            kryptonCustomPaletteBase1.UseKryptonFileDialogs = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(dv);
            panel1.Location = new Point(612, 155);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 515);
            panel1.TabIndex = 13;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(1101, 56);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButton1.Size = new Size(242, 54);
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
            kryptonButton1.TabIndex = 8;
            kryptonButton1.Values.Text = "اضافة صنف";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // kryptonTextBox2
            // 
            kryptonTextBox2.Location = new Point(153, 81);
            kryptonTextBox2.Name = "kryptonTextBox2";
            kryptonTextBox2.RightToLeft = RightToLeft.Yes;
            kryptonTextBox2.Size = new Size(315, 39);
            kryptonTextBox2.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonTextBox2.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonTextBox2.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            kryptonTextBox2.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBox2.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBox2.StateCommon.Border.Rounding = 20F;
            kryptonTextBox2.StateCommon.Content.Color1 = Color.Black;
            kryptonTextBox2.StateCommon.Content.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonTextBox2.TabIndex = 14;
            kryptonTextBox2.Text = "ادخل الاسم";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(37, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(510, 80);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(65, 40);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 16;
            kryptonLabel1.Values.Text = "بحث";
            kryptonLabel1.Click += kryptonLabel1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ion__arrow_back;
            pictureBox2.Location = new Point(12, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(114, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 40;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // clieFormKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 691);
            Controls.Add(pictureBox2);
            Controls.Add(kryptonLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(kryptonTextBox2);
            Controls.Add(panel1);
            Controls.Add(kryptonButton1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Center;
            MaximumSize = new Size(1390, 738);
            MinimumSize = new Size(1390, 738);
            Name = "clieFormKy";
            RightToLeft = RightToLeft.Yes;
            Text = "الاصناف ";
            TitleStyle = Krypton.Toolkit.KryptonFormTitleStyle.Modern;
            Load += ItemFormKy_Load;
            ((System.ComponentModel.ISupportInitialize)dv).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dv;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Panel panel1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private PictureBox pictureBox2;
    }
}