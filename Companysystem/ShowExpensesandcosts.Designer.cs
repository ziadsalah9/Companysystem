namespace Companysystem
{
    partial class ShowExpensesandcosts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowExpensesandcosts));
            dataGridViewCostsandexpans = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCostsandexpans).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCostsandexpans
            // 
            dataGridViewCostsandexpans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCostsandexpans.Location = new Point(12, 83);
            dataGridViewCostsandexpans.Name = "dataGridViewCostsandexpans";
            dataGridViewCostsandexpans.RowHeadersWidth = 51;
            dataGridViewCostsandexpans.Size = new Size(954, 512);
            dataGridViewCostsandexpans.TabIndex = 0;
            dataGridViewCostsandexpans.CellContentClick += dataGridViewCostsandexpans_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ShowExpensesandcosts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 607);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridViewCostsandexpans);
            MaximumSize = new Size(996, 654);
            MinimumSize = new Size(996, 654);
            Name = "ShowExpensesandcosts";
            Text = "المصروفات";
            Load += ShowExpensesandcosts_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCostsandexpans).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCostsandexpans;
        private PictureBox pictureBox1;
    }
}