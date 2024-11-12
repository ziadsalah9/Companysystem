namespace Companysystem
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(30, 40, 45);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button8);
            flowLayoutPanel1.Controls.Add(button9);
            flowLayoutPanel1.Controls.Add(button10);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new Point(1088, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(282, 734);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(pictureBox1);
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(279, 143);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(3, 152);
            button3.Name = "button3";
            button3.Size = new Size(276, 57);
            button3.TabIndex = 3;
            button3.Text = "الاصناف";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(3, 215);
            button4.Name = "button4";
            button4.Size = new Size(276, 52);
            button4.TabIndex = 4;
            button4.Text = "العملاء";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(3, 273);
            button5.Name = "button5";
            button5.Size = new Size(276, 52);
            button5.TabIndex = 5;
            button5.Text = "الموردين";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // button8
            // 
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.White;
            button8.Location = new Point(3, 331);
            button8.Name = "button8";
            button8.Size = new Size(276, 54);
            button8.TabIndex = 6;
            button8.Text = "التكاليف والنفقات";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click_1;
            // 
            // button9
            // 
            button9.FlatStyle = FlatStyle.Flat;
            button9.ForeColor = Color.White;
            button9.Location = new Point(3, 391);
            button9.Name = "button9";
            button9.Size = new Size(276, 64);
            button9.TabIndex = 7;
            button9.Text = "فواتير المشتريات";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click_1;
            // 
            // button10
            // 
            button10.FlatStyle = FlatStyle.Flat;
            button10.ForeColor = Color.White;
            button10.Location = new Point(3, 461);
            button10.Name = "button10";
            button10.Size = new Size(276, 59);
            button10.TabIndex = 8;
            button10.Text = "فواتير المبيعات";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 526);
            button1.Name = "button1";
            button1.Size = new Size(276, 59);
            button1.TabIndex = 9;
            button1.Text = "المخزن";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._1701871424976;
            pictureBox2.Location = new Point(12, 611);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(121, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(267, 304);
            label1.Name = "label1";
            label1.Size = new Size(526, 81);
            label1.TabIndex = 1;
            label1.Text = "Inventory System";
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 734);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Center;
            Name = "HomeForm";
            Text = "الصفحه الرئيسية";
            TitleStyle = Krypton.Toolkit.KryptonFormTitleStyle.Modern;
            Load += HomeForm_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button2;
        private Button button8;
        private Button button9;
        private Button button10;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
    }
}