namespace Companysystem.SalesForms
{
    partial class OkOrNotWhenQuanityGreaterThanEndingStore
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
            LB1 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // LB1
            // 
            LB1.Font = new Font("Segoe UI", 25F);
            LB1.Location = new Point(162, 65);
            LB1.Name = "LB1";
            LB1.Size = new Size(549, 57);
            LB1.TabIndex = 0;
            LB1.Text = " لا يوجد فى المخزن كمية كافية";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.MediumSeaGreen;
            label1.Location = new Point(413, 146);
            label1.Name = "label1";
            label1.Size = new Size(199, 35);
            label1.TabIndex = 1;
            label1.Text = "متبقي فى المخزن";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(369, 146);
            label2.Name = "label2";
            label2.Size = new Size(28, 35);
            label2.TabIndex = 2;
            label2.Text = "0";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.MediumSeaGreen;
            label3.Location = new Point(292, 146);
            label3.Name = "label3";
            label3.Size = new Size(62, 35);
            label3.TabIndex = 3;
            label3.Text = "فقط";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 25F);
            label4.Location = new Point(208, 326);
            label4.Name = "label4";
            label4.Size = new Size(441, 57);
            label4.TabIndex = 4;
            label4.Text = "هل تريد اكمال العملية ؟";
            label4.Click += label4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(465, 421);
            button2.Name = "button2";
            button2.Size = new Size(204, 62);
            button2.TabIndex = 6;
            button2.Text = "نعم";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(208, 421);
            button3.Name = "button3";
            button3.Size = new Size(204, 62);
            button3.TabIndex = 7;
            button3.Text = "لا";
            button3.UseVisualStyleBackColor = true;
            // 
            // OkOrNotWhenQuanityGreaterThanEndingStore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 544);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LB1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximumSize = new Size(930, 591);
            MinimumSize = new Size(930, 591);
            Name = "OkOrNotWhenQuanityGreaterThanEndingStore";
            Text = "OkOrNotWhenQuanityGreaterThanEndingStore";
            Load += OkOrNotWhenQuanityGreaterThanEndingStore_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LB1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private Button button3;
    }
}