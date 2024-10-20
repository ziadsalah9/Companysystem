namespace Companysystem.Supllierforms
{
    partial class ADDsupplierform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADDsupplierform));
            pictureBox1 = new PictureBox();
            addbtn = new Button();
            label1 = new Label();
            supnametxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // addbtn
            // 
            addbtn.Location = new Point(67, 352);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(160, 64);
            addbtn.TabIndex = 9;
            addbtn.Text = "أضافة";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += addbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(649, 193);
            label1.Name = "label1";
            label1.Size = new Size(111, 30);
            label1.TabIndex = 8;
            label1.Text = "اسم المورد";
            // 
            // supnametxt
            // 
            supnametxt.Location = new Point(299, 184);
            supnametxt.Multiline = true;
            supnametxt.Name = "supnametxt";
            supnametxt.Size = new Size(276, 57);
            supnametxt.TabIndex = 7;
            // 
            // ADDsupplierform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(addbtn);
            Controls.Add(label1);
            Controls.Add(supnametxt);
            Name = "ADDsupplierform";
            Text = "ADDsupplierform";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button addbtn;
        private Label label1;
        private TextBox supnametxt;
    }
}