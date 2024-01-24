namespace BMI_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(211, 19);
            label1.Name = "label1";
            label1.Size = new Size(313, 44);
            label1.TabIndex = 0;
            label1.Text = "BMI Calculator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans Ultra Bold Condensed", 12F);
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(209, 32);
            label2.TabIndex = 1;
            label2.Text = "Enter Your Weight";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gill Sans Ultra Bold Condensed", 12F);
            label3.Location = new Point(12, 133);
            label3.Name = "label3";
            label3.Size = new Size(243, 32);
            label3.TabIndex = 1;
            label3.Text = "Enter Your Height(m)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gill Sans Ultra Bold Condensed", 12F);
            label4.Location = new Point(12, 187);
            label4.Name = "label4";
            label4.Size = new Size(112, 32);
            label4.TabIndex = 1;
            label4.Text = "Your BMI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gill Sans Ultra Bold Condensed", 12F);
            label5.Location = new Point(12, 240);
            label5.Name = "label5";
            label5.Size = new Size(112, 32);
            label5.TabIndex = 1;
            label5.Text = "Comment";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Gill Sans Ultra Bold Condensed", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 301);
            button1.Name = "button1";
            button1.Size = new Size(225, 73);
            button1.TabIndex = 2;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Gill Sans Ultra Bold Condensed", 12F);
            textBox1.Location = new Point(261, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 37);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Gill Sans Ultra Bold Condensed", 12F);
            textBox2.Location = new Point(261, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 37);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Gill Sans Ultra Bold Condensed", 12F);
            textBox3.Location = new Point(261, 187);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 37);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Gill Sans Ultra Bold Condensed", 12F);
            textBox4.Location = new Point(261, 240);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(305, 37);
            textBox4.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "BMI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}
