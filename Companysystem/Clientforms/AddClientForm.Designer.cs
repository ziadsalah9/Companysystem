namespace Companysystem.Clientforms
{
    partial class AddClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClientForm));
            clientnametxt = new TextBox();
            label1 = new Label();
            addbtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // clientnametxt
            // 
            clientnametxt.Location = new Point(500, 206);
            clientnametxt.Multiline = true;
            clientnametxt.Name = "clientnametxt";
            clientnametxt.Size = new Size(398, 94);
            clientnametxt.TabIndex = 0;
            clientnametxt.TextChanged += clientnametxt_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(959, 226);
            label1.Name = "label1";
            label1.Size = new Size(161, 41);
            label1.TabIndex = 2;
            label1.Text = "اسم العميل";
            // 
            // addbtn
            // 
            addbtn.Location = new Point(45, 468);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(250, 64);
            addbtn.TabIndex = 4;
            addbtn.Text = "أضافة";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += addbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // AddClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 581);
            Controls.Add(pictureBox1);
            Controls.Add(addbtn);
            Controls.Add(label1);
            Controls.Add(clientnametxt);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximumSize = new Size(1207, 628);
            MinimumSize = new Size(1207, 628);
            Name = "AddClientForm";
            Text = "AddClientForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox clientnametxt;
        private Label label1;
        private Button addbtn;
        private PictureBox pictureBox1;
    }
}