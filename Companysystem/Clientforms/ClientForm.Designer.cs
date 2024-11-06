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
            btnaddclient.Anchor = AnchorStyles.None;
            btnaddclient.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnaddclient.Font = new Font("Segoe UI", 12F);
            btnaddclient.Location = new Point(905, 55);
            btnaddclient.Name = "btnaddclient";
            btnaddclient.Size = new Size(231, 56);
            btnaddclient.TabIndex = 0;
            btnaddclient.Text = "أضافة عميل";
            btnaddclient.UseVisualStyleBackColor = true;
            btnaddclient.Click += btnaddclient_Click_1;
            // 
            // btnshowclients
            // 
            btnshowclients.Anchor = AnchorStyles.None;
            btnshowclients.Font = new Font("Segoe UI", 12F);
            btnshowclients.Location = new Point(905, 229);
            btnshowclients.Name = "btnshowclients";
            btnshowclients.Size = new Size(231, 56);
            btnshowclients.TabIndex = 1;
            btnshowclients.Text = "عرض العملاء";
            btnshowclients.UseVisualStyleBackColor = true;
            btnshowclients.Click += btnshowclients_Click;
            // 
            // btnremoveclient
            // 
            btnremoveclient.Anchor = AnchorStyles.None;
            btnremoveclient.Font = new Font("Segoe UI", 12F);
            btnremoveclient.Location = new Point(905, 502);
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
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(654, 503);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.ForeColor = Color.LimeGreen;
            label1.Location = new Point(857, 403);
            label1.Name = "label1";
            label1.Size = new Size(320, 20);
            label1.TabIndex = 4;
            label1.Text = "لحذف العميل من فضلك قم بادخال الرقم التعريفي";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.None;
            numericUpDown1.Location = new Point(905, 452);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(231, 27);
            numericUpDown1.TabIndex = 5;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
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
            ClientSize = new Size(1189, 581);
            Controls.Add(pictureBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnremoveclient);
            Controls.Add(btnshowclients);
            Controls.Add(btnaddclient);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximumSize = new Size(1207, 628);
            MinimumSize = new Size(1207, 628);
            Name = "ClientForm";
            Text = "صفحة العملاء";
            WindowState = FormWindowState.Maximized;
            Load += ClientForm_Load;
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