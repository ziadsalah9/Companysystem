﻿namespace Companysystem.ItemsForms
{
    partial class ItemFormKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemFormKy));
            dv = new Krypton.Toolkit.KryptonDataGridView();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            panel1 = new Panel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dv).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dv
            // 
            dv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dv.BorderStyle = BorderStyle.None;
            dv.ColumnHeadersHeight = 36;
            dv.Dock = DockStyle.Fill;
            dv.Location = new Point(0, 0);
            dv.Name = "dv";
            dv.RightToLeft = RightToLeft.Yes;
            dv.RowHeadersWidth = 51;
            dv.Size = new Size(559, 552);
            dv.StateCommon.Background.Color1 = Color.FromArgb(250, 252, 252);
            dv.StateCommon.Background.Color2 = Color.FromArgb(250, 252, 252);
            dv.StateCommon.Background.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Form;
            dv.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dv.StateCommon.DataCell.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dv.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(6, 174, 224);
            dv.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(8, 142, 254);
            dv.StateCommon.HeaderRow.Back.Color1 = Color.White;
            dv.StateCommon.HeaderRow.Back.Color2 = Color.White;
            dv.TabIndex = 0;
            dv.CellContentClick += dv_CellContentClick;
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Location = new Point(26, 492);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(417, 40);
            kryptonTextBox1.StateCommon.Back.Color1 = Color.White;
            kryptonTextBox1.StateCommon.Border.Color1 = Color.FromArgb(250, 252, 252);
            kryptonTextBox1.StateCommon.Border.Color2 = Color.FromArgb(250, 252, 252);
            kryptonTextBox1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBox1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonTextBox1.StateCommon.Border.Rounding = 20F;
            kryptonTextBox1.StateCommon.Border.Width = 0;
            kryptonTextBox1.StateCommon.Content.Color1 = Color.Gray;
            kryptonTextBox1.StateCommon.Content.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonTextBox1.TabIndex = 7;
            kryptonTextBox1.Text = "أدخل رقم الصنف الذى تريد حذفه";
            kryptonTextBox1.TextAlign = HorizontalAlignment.Right;
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
            panel1.Location = new Point(787, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(559, 552);
            panel1.TabIndex = 13;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(235, 69);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(149, 40);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 11;
            kryptonLabel3.Values.Text = "اضافة صنف";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(105, 435);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(341, 24);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.Turquoise;
            kryptonLabel2.TabIndex = 10;
            kryptonLabel2.Values.Text = "لحذف صنف عليك اختيار الرقم المعبر عنه فى الجدول";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(235, 348);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(138, 40);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 9;
            kryptonLabel1.Values.Text = "حذف صنف";
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(26, 577);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButton1.Size = new Size(176, 44);
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
            kryptonButton1.Values.Text = "حذف";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(390, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // ItemFormKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 691);
            Controls.Add(pictureBox1);
            Controls.Add(kryptonTextBox1);
            Controls.Add(panel1);
            Controls.Add(kryptonLabel3);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonLabel1);
            Controls.Add(kryptonButton1);
            FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Center;
            MaximumSize = new Size(1390, 738);
            MinimumSize = new Size(1390, 738);
            Name = "ItemFormKy";
            RightToLeft = RightToLeft.Yes;
            Text = "الاصناف ";
            TitleStyle = Krypton.Toolkit.KryptonFormTitleStyle.Modern;
            Load += ItemFormKy_Load;
            ((System.ComponentModel.ISupportInitialize)dv).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dv;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Panel panel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private PictureBox pictureBox1;
    }
}