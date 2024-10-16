namespace Companysystem.Clientforms
{
    partial class AddClientForm
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
            clientnametxt = new TextBox();
            clientnotxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            addbtn = new Button();
            Backbtn = new Button();
            SuspendLayout();
            // 
            // clientnametxt
            // 
            clientnametxt.Location = new Point(334, 42);
            clientnametxt.Multiline = true;
            clientnametxt.Name = "clientnametxt";
            clientnametxt.Size = new Size(276, 57);
            clientnametxt.TabIndex = 0;
            // 
            // clientnotxt
            // 
            clientnotxt.Location = new Point(334, 153);
            clientnotxt.Multiline = true;
            clientnotxt.Name = "clientnotxt";
            clientnotxt.Size = new Size(276, 57);
            clientnotxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(664, 51);
            label1.Name = "label1";
            label1.Size = new Size(117, 30);
            label1.TabIndex = 2;
            label1.Text = "اسم العميل";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(664, 164);
            label2.Name = "label2";
            label2.Size = new Size(111, 30);
            label2.TabIndex = 3;
            label2.Text = "رقم العميل";
            label2.Click += label2_Click;
            // 
            // addbtn
            // 
            addbtn.Location = new Point(64, 329);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(160, 64);
            addbtn.TabIndex = 4;
            addbtn.Text = "أضافة";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += addbtn_Click;
            // 
            // Backbtn
            // 
            Backbtn.Location = new Point(48, 20);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(115, 33);
            Backbtn.TabIndex = 5;
            Backbtn.Text = "العودة";
            Backbtn.UseVisualStyleBackColor = true;
            Backbtn.Click += Backbtn_Click;
            // 
            // AddClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Backbtn);
            Controls.Add(addbtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(clientnotxt);
            Controls.Add(clientnametxt);
            Name = "AddClientForm";
            Text = "AddClientForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox clientnametxt;
        private TextBox clientnotxt;
        private Label label1;
        private Label label2;
        private Button addbtn;
        private Button Backbtn;
    }
}