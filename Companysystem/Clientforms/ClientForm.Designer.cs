namespace Companysystem.Clientforms
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            btnaddclient = new Button();
            btnshowclients = new Button();
            btnremoveclient = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnaddclient
            // 
            btnaddclient.Font = new Font("Segoe UI", 12F);
            btnaddclient.Location = new Point(521, 53);
            btnaddclient.Name = "btnaddclient";
            btnaddclient.Size = new Size(231, 56);
            btnaddclient.TabIndex = 0;
            btnaddclient.Text = "أضافة عميل";
            btnaddclient.UseVisualStyleBackColor = true;
            btnaddclient.Click += btnaddclient_Click_1;
            // 
            // btnshowclients
            // 
            btnshowclients.Font = new Font("Segoe UI", 12F);
            btnshowclients.Location = new Point(521, 160);
            btnshowclients.Name = "btnshowclients";
            btnshowclients.Size = new Size(231, 56);
            btnshowclients.TabIndex = 1;
            btnshowclients.Text = "عرض العملاء";
            btnshowclients.UseVisualStyleBackColor = true;
            btnshowclients.Click += btnshowclients_Click;
            // 
            // btnremoveclient
            // 
            btnremoveclient.Font = new Font("Segoe UI", 12F);
            btnremoveclient.Location = new Point(521, 368);
            btnremoveclient.Name = "btnremoveclient";
            btnremoveclient.Size = new Size(231, 56);
            btnremoveclient.TabIndex = 2;
            btnremoveclient.Text = "حذف عميل";
            btnremoveclient.UseVisualStyleBackColor = true;
            btnremoveclient.Click += btnremoveclient_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(433, 385);
            dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.LimeGreen;
            label1.Location = new Point(468, 280);
            label1.Name = "label1";
            label1.Size = new Size(320, 20);
            label1.TabIndex = 4;
            label1.Text = "لحذف العميل من فضلك قم بادخال الرقم التعريفي";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(521, 323);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(231, 27);
            numericUpDown1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnremoveclient);
            Controls.Add(btnshowclients);
            Controls.Add(btnaddclient);
            Name = "ClientForm";
            Text = "صفحة العملاء";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnaddclient;
        private Button btnshowclients;
        private Button btnremoveclient;
        private DataGridView dataGridView1;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private PictureBox pictureBox1;
    }
}