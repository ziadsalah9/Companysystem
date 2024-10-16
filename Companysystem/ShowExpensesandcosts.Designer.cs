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
            dataGridViewCostsandexpans = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCostsandexpans).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCostsandexpans
            // 
            dataGridViewCostsandexpans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCostsandexpans.Location = new Point(12, 14);
            dataGridViewCostsandexpans.Name = "dataGridViewCostsandexpans";
            dataGridViewCostsandexpans.RowHeadersWidth = 51;
            dataGridViewCostsandexpans.Size = new Size(776, 424);
            dataGridViewCostsandexpans.TabIndex = 0;
            dataGridViewCostsandexpans.CellContentClick += dataGridViewCostsandexpans_CellContentClick;
            // 
            // ShowExpensesandcosts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewCostsandexpans);
            Name = "ShowExpensesandcosts";
            Text = "المصروفات";
            Load += ShowExpensesandcosts_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCostsandexpans).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCostsandexpans;
    }
}