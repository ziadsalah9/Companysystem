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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            analysisdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            analysisdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            analysisdgv.DefaultCellStyle = dataGridViewCellStyle5;
            analysisdgv.Location = new Point(12, 234);
            analysisdgv.Name = "analysisdgv";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            analysisdgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            analysisdgv.RowHeadersWidth = 51;
            analysisdgv.Size = new Size(1152, 324);
            analysisdgv.TabIndex = 0;
            // 
            // analysisnumeric
            // 
            analysisnumeric.Location = new Point(367, 77);
            analysisnumeric.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            analysisnumeric.Name = "analysisnumeric";
            analysisnumeric.Size = new Size(377, 27);
            analysisnumeric.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(824, 67);
            label1.Name = "label1";
            label1.Size = new Size(340, 35);
            label1.TabIndex = 2;
            label1.Text = "قم بادخال العام الذى تريد تحليله";
            // 
            // btnsearch
            // 
            btnsearch.Location = new Point(30, 67);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(176, 35);
            btnsearch.TabIndex = 3;
            btnsearch.Text = "ابحث";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // AnalysisCostsInYear
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 581);
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