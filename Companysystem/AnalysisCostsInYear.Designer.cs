namespace Companysystem
{
    partial class AnalysisCostsInYear
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            analysisdgv = new DataGridView();
            analysisnumeric = new NumericUpDown();
            label1 = new Label();
            btnsearch = new Button();
            ((System.ComponentModel.ISupportInitialize)analysisdgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)analysisnumeric).BeginInit();
            SuspendLayout();
            // 
            // analysisdgv
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            analysisdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            analysisdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            analysisdgv.DefaultCellStyle = dataGridViewCellStyle2;
            analysisdgv.Location = new Point(23, 70);
            analysisdgv.Name = "analysisdgv";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            analysisdgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            analysisdgv.RowHeadersWidth = 51;
            analysisdgv.Size = new Size(751, 357);
            analysisdgv.TabIndex = 0;
            // 
            // analysisnumeric
            // 
            analysisnumeric.Location = new Point(208, 30);
            analysisnumeric.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            analysisnumeric.Name = "analysisnumeric";
            analysisnumeric.Size = new Size(186, 27);
            analysisnumeric.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(434, 22);
            label1.Name = "label1";
            label1.Size = new Size(340, 35);
            label1.TabIndex = 2;
            label1.Text = "قم بادخال العام الذى تريد تحليله";
            // 
            // btnsearch
            // 
            btnsearch.Location = new Point(23, 25);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(134, 35);
            btnsearch.TabIndex = 3;
            btnsearch.Text = "ابحث";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // AnalysisCostsInYear
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnsearch);
            Controls.Add(label1);
            Controls.Add(analysisnumeric);
            Controls.Add(analysisdgv);
            Font = new Font("Segoe UI", 9F);
            Name = "AnalysisCostsInYear";
            Text = "تحليل المصروفات خلال عام";
            Load += AnalysisCostsInYear_Load;
            ((System.ComponentModel.ISupportInitialize)analysisdgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)analysisnumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView analysisdgv;
        private NumericUpDown analysisnumeric;
        private Label label1;
        private Button btnsearch;
    }
}