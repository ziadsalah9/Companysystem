namespace Companysystem.Supllierforms
{
    partial class Supplierform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supplierform));
            pictureBox1 = new PictureBox();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnremovesup = new Button();
            btnshowsuppliers = new Button();
            btnaddsupplier = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(526, 329);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(231, 27);
            numericUpDown1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.LimeGreen;
            label1.Location = new Point(473, 286);
            label1.Name = "label1";
            label1.Size = new Size(317, 20);
            label1.TabIndex = 12;
            label1.Text = "لحذف المورد من فضلك قم بادخال الرقم التعريفي";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(433, 385);
            dataGridView1.TabIndex = 11;
            // 
            // btnremovesup
            // 
            btnremovesup.Font = new Font("Segoe UI", 12F);
            btnremovesup.Location = new Point(526, 374);
            btnremovesup.Name = "btnremovesup";
            btnremovesup.Size = new Size(231, 56);
            btnremovesup.TabIndex = 10;
            btnremovesup.Text = "حذف مورد";
            btnremovesup.UseVisualStyleBackColor = true;
            btnremovesup.Click += btnremovesup_Click;
            // 
            // btnshowsuppliers
            // 
            btnshowsuppliers.Font = new Font("Segoe UI", 12F);
            btnshowsuppliers.Location = new Point(526, 166);
            btnshowsuppliers.Name = "btnshowsuppliers";
            btnshowsuppliers.Size = new Size(231, 56);
            btnshowsuppliers.TabIndex = 9;
            btnshowsuppliers.Text = "عرض الموردين";
            btnshowsuppliers.UseVisualStyleBackColor = true;
            btnshowsuppliers.Click += btnshowsuppliers_Click;
            // 
            // btnaddsupplier
            // 
            btnaddsupplier.Font = new Font("Segoe UI", 12F);
            btnaddsupplier.Location = new Point(526, 59);
            btnaddsupplier.Name = "btnaddsupplier";
            btnaddsupplier.Size = new Size(231, 56);
            btnaddsupplier.TabIndex = 8;
            btnaddsupplier.Text = "أضافة مورد";
            btnaddsupplier.UseVisualStyleBackColor = true;
            btnaddsupplier.Click += btnaddsupplier_Click;
            // 
            // Supplierform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnremovesup);
            Controls.Add(btnshowsuppliers);
            Controls.Add(btnaddsupplier);
            Name = "Supplierform";
            Text = "Supplierform";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnremovesup;
        private Button btnshowsuppliers;
        private Button btnaddsupplier;
    }
}