namespace Companysystem.SalesForms
{
    partial class BillsForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillsForms));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ShowBilldv = new DataGridView();
            button1 = new Button();
            Yeardd = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ShowBilldv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Yeardd).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(684, 134);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 0;
            label1.Text = "اضافة فاتورة";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(684, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // ShowBilldv
            // 
            ShowBilldv.AllowUserToDeleteRows = false;
            ShowBilldv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ShowBilldv.Location = new Point(39, 177);
            ShowBilldv.Name = "ShowBilldv";
            ShowBilldv.ReadOnly = true;
            ShowBilldv.RowHeadersWidth = 51;
            ShowBilldv.Size = new Size(735, 244);
            ShowBilldv.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(39, 130);
            button1.Name = "button1";
            button1.Size = new Size(103, 29);
            button1.TabIndex = 7;
            button1.Text = "بحث";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Yeardd
            // 
            Yeardd.Location = new Point(39, 80);
            Yeardd.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            Yeardd.Name = "Yeardd";
            Yeardd.Size = new Size(171, 27);
            Yeardd.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(240, 79);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 11;
            label2.Text = "ادخل السنة";
            // 
            // BillsForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 450);
            Controls.Add(label2);
            Controls.Add(Yeardd);
            Controls.Add(button1);
            Controls.Add(ShowBilldv);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "BillsForms";
            Text = "BillsForms";
            Load += BillsForms_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ShowBilldv).EndInit();
            ((System.ComponentModel.ISupportInitialize)Yeardd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridView ShowBilldv;
        private Button button1;
        private NumericUpDown Yeardd;
        private Label label2;
    }
}