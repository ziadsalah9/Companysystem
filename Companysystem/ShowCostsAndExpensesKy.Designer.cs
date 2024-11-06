namespace Companysystem
{
    partial class ShowCostsAndExpensesKy
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
            dv = new Krypton.Toolkit.KryptonDataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dv
            // 
            dv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dv.BorderStyle = BorderStyle.None;
            dv.ColumnHeadersHeight = 36;
            dv.Location = new Point(39, 62);
            dv.Name = "dv";
            dv.RightToLeft = RightToLeft.Yes;
            dv.RowHeadersWidth = 51;
            dv.Size = new Size(1001, 543);
            dv.StateCommon.Background.Color1 = Color.FromArgb(250, 252, 252);
            dv.StateCommon.Background.Color2 = Color.FromArgb(250, 252, 252);
            dv.StateCommon.Background.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Form;
            dv.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dv.StateCommon.DataCell.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dv.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(6, 174, 224);
            dv.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(8, 142, 254);
            dv.StateCommon.HeaderRow.Back.Color1 = Color.White;
            dv.StateCommon.HeaderRow.Back.Color2 = Color.White;
            dv.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ion__arrow_back;
            pictureBox1.Location = new Point(52, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ShowCostsAndExpensesKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 659);
            Controls.Add(pictureBox1);
            Controls.Add(dv);
            FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Center;
            Name = "ShowCostsAndExpensesKy";
            Text = "عرض المصروفات والنفقات";
            TitleStyle = Krypton.Toolkit.KryptonFormTitleStyle.Modern;
            Load += ShowCostsAndExpensesKy_Load;
            ((System.ComponentModel.ISupportInitialize)dv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dv;
        private PictureBox pictureBox1;
    }
}