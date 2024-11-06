namespace Companysystem.PurchasesBillsForm
{
    partial class PurchasesBillSormKy
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
            dv = new Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dv).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ion__arrow_back;
            pictureBox1.Location = new Point(41, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dv
            // 
            dv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dv.BorderStyle = BorderStyle.None;
            dv.ColumnHeadersHeight = 36;
            dv.Location = new Point(41, 243);
            dv.Name = "dv";
            dv.RightToLeft = RightToLeft.Yes;
            dv.RowHeadersWidth = 51;
            dv.Size = new Size(1425, 479);
            dv.StateCommon.Background.Color1 = Color.FromArgb(250, 252, 252);
            dv.StateCommon.Background.Color2 = Color.FromArgb(250, 252, 252);
            dv.StateCommon.Background.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Form;
            dv.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dv.StateCommon.DataCell.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dv.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(6, 174, 224);
            dv.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(8, 142, 254);
            dv.StateCommon.HeaderColumn.Content.Padding = new Padding(0, -1, -1, -1);
            dv.StateCommon.HeaderRow.Back.Color1 = Color.White;
            dv.StateCommon.HeaderRow.Back.Color2 = Color.White;
            dv.TabIndex = 40;
            dv.CellContentClick += dv_CellContentClick;
            // 
            // PurchasesBillSormKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 734);
            Controls.Add(pictureBox1);
            Controls.Add(dv);
            ForeColor = Color.Black;
            FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Center;
            Name = "PurchasesBillSormKy";
            Text = "فواتير المشتريات";
            TitleStyle = Krypton.Toolkit.KryptonFormTitleStyle.Modern;
            Load += PurchasesBillSormKy_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonDataGridView dv;
    }
}