namespace Companysystem
{
    partial class deleteEXPANSES
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
            label1 = new Label();
            label2 = new Label();
            btnokdelete = new Button();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(303, 115);
            label1.Name = "label1";
            label1.Size = new Size(253, 50);
            label1.TabIndex = 0;
            label1.Text = "للحذف ادخل ال";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22F);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(230, 115);
            label2.Name = "label2";
            label2.Size = new Size(58, 50);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // btnokdelete
            // 
            btnokdelete.Location = new Point(46, 354);
            btnokdelete.Name = "btnokdelete";
            btnokdelete.Size = new Size(162, 44);
            btnokdelete.TabIndex = 3;
            btnokdelete.Text = "تاكيد الحذف";
            btnokdelete.UseVisualStyleBackColor = true;
            btnokdelete.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown1.ForeColor = SystemColors.ActiveCaptionText;
            numericUpDown1.Location = new Point(251, 209);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(282, 27);
            numericUpDown1.TabIndex = 4;
            // 
            // deleteEXPANSES
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(btnokdelete);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "deleteEXPANSES";
            Text = "deleteEXPANSES";
            Load += deleteEXPANSES_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnokdelete;
        private NumericUpDown numericUpDown1;
    }
}