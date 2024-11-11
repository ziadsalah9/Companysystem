namespace Companysystem.SalesForms
{
    partial class OkOrNotWhenQuanityGreaterThanEndingStoreKy
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
            LB1 = new Label();
            label4 = new Label();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // LB1
            // 
            LB1.Font = new Font("Segoe UI", 25F);
            LB1.Location = new Point(585, 58);
            LB1.Name = "LB1";
            LB1.Size = new Size(549, 57);
            LB1.TabIndex = 1;
            LB1.Text = " لا يوجد فى المخزن كمية كافية";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 25F);
            label4.Location = new Point(290, 360);
            label4.Name = "label4";
            label4.Size = new Size(441, 57);
            label4.TabIndex = 5;
            label4.Text = "هل تريد اكمال العملية ؟";
            // 
            // kryptonButton2
            // 
            kryptonButton2.Location = new Point(76, 482);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButton2.Size = new Size(387, 81);
            kryptonButton2.StateCommon.Back.Color1 = Color.FromArgb(255, 0, 50);
            kryptonButton2.StateCommon.Back.Color2 = Color.FromArgb(255, 0, 50);
            kryptonButton2.StateCommon.Back.ColorAngle = 45F;
            kryptonButton2.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 224);
            kryptonButton2.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButton2.StateCommon.Border.ColorAngle = 45F;
            kryptonButton2.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton2.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton2.StateCommon.Border.Rounding = 20F;
            kryptonButton2.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton2.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButton2.StateCommon.Content.ShortText.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton2.TabIndex = 45;
            kryptonButton2.Values.Text = "لا";
            kryptonButton2.Click += kryptonButton2_Click;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(650, 482);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButton1.Size = new Size(387, 81);
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
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton1.TabIndex = 44;
            kryptonButton1.Values.Text = "نعم";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.MediumSeaGreen;
            label3.Location = new Point(343, 211);
            label3.Name = "label3";
            label3.Size = new Size(62, 35);
            label3.TabIndex = 48;
            label3.Text = "فقط";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(423, 211);
            label2.Name = "label2";
            label2.Size = new Size(77, 35);
            label2.TabIndex = 47;
            label2.Text = "0";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.MediumSeaGreen;
            label1.Location = new Point(516, 211);
            label1.Name = "label1";
            label1.Size = new Size(199, 35);
            label1.TabIndex = 46;
            label1.Text = "متبقي فى المخزن";
            // 
            // OkOrNotWhenQuanityGreaterThanEndingStoreKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 627);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(kryptonButton2);
            Controls.Add(kryptonButton1);
            Controls.Add(label4);
            Controls.Add(LB1);
           // FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Center;
            Name = "OkOrNotWhenQuanityGreaterThanEndingStoreKy";
            Text = "";
            //TitleStyle = Krypton.Toolkit.KryptonFormTitleStyle.Modern;
            Load += OkOrNotWhenQuanityGreaterThanEndingStoreKy_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LB1;
        private Label label4;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}