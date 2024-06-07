namespace fukuv0607
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            timer3 = new System.Windows.Forms.Timer(components);
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(360, 63);
            label1.Name = "label1";
            label1.Size = new Size(54, 46);
            label1.TabIndex = 0;
            label1.Text = "◆";
            label1.Click += label1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(110, 694);
            label4.Name = "label4";
            label4.Size = new Size(23, 28);
            label4.TabIndex = 3;
            label4.Text = "1";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.IndianRed;
            label2.Font = new Font("Yu Gothic UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(344, 289);
            label2.Name = "label2";
            label2.Size = new Size(71, 37);
            label2.TabIndex = 4;
            label2.Text = "　　";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 694);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 5;
            label3.Text = "経過時間";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(536, 665);
            label5.Name = "label5";
            label5.Size = new Size(120, 28);
            label5.TabIndex = 6;
            label5.Text = "現在のX速度";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(686, 665);
            label6.Name = "label6";
            label6.Size = new Size(52, 28);
            label6.TabIndex = 7;
            label6.Text = "速度";
            label6.Click += label6_Click;
            // 
            // timer3
            // 
            timer3.Enabled = true;
            timer3.Tick += timer3_Tick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(537, 709);
            label7.Name = "label7";
            label7.Size = new Size(119, 28);
            label7.TabIndex = 8;
            label7.Text = "現在のY速度";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(686, 709);
            label8.Name = "label8";
            label8.Size = new Size(52, 28);
            label8.TabIndex = 9;
            label8.Text = "速度";
            label8.Click += label8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 777);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private System.Windows.Forms.Timer timer3;
        private Label label7;
        private Label label8;
    }
}