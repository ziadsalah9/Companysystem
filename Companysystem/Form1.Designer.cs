namespace Companysystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BtnAdd = new Button();
            EmpNameTxt = new TextBox();
            label1 = new Label();
            Next = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(720, 400);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(155, 29);
            BtnAdd.TabIndex = 0;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // EmpNameTxt
            // 
            EmpNameTxt.Location = new Point(555, 32);
            EmpNameTxt.Name = "EmpNameTxt";
            EmpNameTxt.Size = new Size(190, 27);
            EmpNameTxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(765, 28);
            label1.Name = "label1";
            label1.Size = new Size(110, 28);
            label1.TabIndex = 2;
            label1.Text = "اسم الصنف";
            // 
            // Next
            // 
            Next.Location = new Point(12, 12);
            Next.Name = "Next";
            Next.Size = new Size(121, 31);
            Next.TabIndex = 3;
            Next.Text = "التالي";
            Next.UseVisualStyleBackColor = true;
            Next.Click += Next_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(43, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 204);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 5;
            label2.Text = "عملاء";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 450);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(Next);
            Controls.Add(label1);
            Controls.Add(EmpNameTxt);
            Controls.Add(BtnAdd);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAdd;
        private TextBox EmpNameTxt;
        private Label label1;
        private Button Next;
        private PictureBox pictureBox1;
        private Label label2;
    }
}
