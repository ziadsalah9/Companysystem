namespace Companysystem.ItemsForms
{
    partial class Itemsform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Itemsform));
            BtnAddItem = new Button();
            btnShowItem = new Button();
            btnDeleteItem = new Button();
            deleteitemnum = new NumericUpDown();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)deleteitemnum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnAddItem
            // 
            BtnAddItem.Font = new Font("Segoe UI", 12F);
            BtnAddItem.Location = new Point(905, 55);
            BtnAddItem.Name = "BtnAddItem";
            BtnAddItem.Size = new Size(227, 53);
            BtnAddItem.TabIndex = 0;
            BtnAddItem.Text = "أضافة صنف";
            BtnAddItem.UseVisualStyleBackColor = true;
            BtnAddItem.Click += BtnAddItem_Click;
            // 
            // btnShowItem
            // 
            btnShowItem.Font = new Font("Segoe UI", 12F);
            btnShowItem.Location = new Point(905, 229);
            btnShowItem.Name = "btnShowItem";
            btnShowItem.Size = new Size(227, 57);
            btnShowItem.TabIndex = 1;
            btnShowItem.Text = "عرض الأصناف";
            btnShowItem.UseVisualStyleBackColor = true;
            btnShowItem.Click += btnShowItem_Click;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.Font = new Font("Segoe UI", 12F);
            btnDeleteItem.Location = new Point(905, 501);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(227, 57);
            btnDeleteItem.TabIndex = 2;
            btnDeleteItem.Text = "حذف صنف";
            btnDeleteItem.UseVisualStyleBackColor = true;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // deleteitemnum
            // 
            deleteitemnum.Location = new Point(905, 454);
            deleteitemnum.Name = "deleteitemnum";
            deleteitemnum.Size = new Size(231, 27);
            deleteitemnum.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.LimeGreen;
            label1.Location = new Point(857, 406);
            label1.Name = "label1";
            label1.Size = new Size(320, 20);
            label1.TabIndex = 6;
            label1.Text = "لحذف العميل من فضلك قم بادخال الرقم التعريفي";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(654, 503);
            dataGridView1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Itemsform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 581);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(deleteitemnum);
            Controls.Add(label1);
            Controls.Add(btnDeleteItem);
            Controls.Add(btnShowItem);
            Controls.Add(BtnAddItem);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximumSize = new Size(1207, 628);
            MinimumSize = new Size(1207, 628);
            Name = "Itemsform";
            Text = "Itemsform";
            Load += Itemsform_Load;
            ((System.ComponentModel.ISupportInitialize)deleteitemnum).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAddItem;
        private Button btnShowItem;
        private Button btnDeleteItem;
        private NumericUpDown deleteitemnum;
        private Label label1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
    }
}