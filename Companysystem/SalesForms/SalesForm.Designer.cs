namespace Companysystem.SalesForms
{
    partial class SalesForm
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
            components = new System.ComponentModel.Container();
            dateTimePicker1 = new DateTimePicker();
            listclientsname = new ListBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            itemBindingSource = new BindingSource(components);
            listBox1 = new ListBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(442, 44);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // listclientsname
            // 
            listclientsname.FormattingEnabled = true;
            listclientsname.Location = new Point(442, 77);
            listclientsname.Name = "listclientsname";
            listclientsname.Size = new Size(250, 104);
            listclientsname.TabIndex = 1;
            listclientsname.SelectedIndexChanged += listclientsname_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(29, 412);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(723, 42);
            label1.Name = "label1";
            label1.Size = new Size(65, 28);
            label1.TabIndex = 3;
            label1.Text = "التاريخ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(723, 111);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 4;
            label2.Text = "العميل";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(442, 352);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(250, 27);
            numericUpDown1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(725, 352);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 6;
            label3.Text = "الكمية";
            // 
            // itemBindingSource
            // 
            itemBindingSource.DataSource = typeof(Models.Item);
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(442, 200);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(250, 104);
            listBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(723, 244);
            label4.Name = "label4";
            label4.Size = new Size(71, 28);
            label4.TabIndex = 8;
            label4.Text = "الصنف";
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listclientsname);
            Controls.Add(dateTimePicker1);
            Name = "SalesForm";
            Text = "SalesForm";
            Load += SalesForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private ListBox listclientsname;
        private Button button1;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private BindingSource itemBindingSource;
        private ListBox listBox1;
        private Label label4;
    }
}