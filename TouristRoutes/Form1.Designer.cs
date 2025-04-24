namespace TouristRoutes
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button2 = new Button();
            label7 = new Label();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            label6 = new Label();
            tabPage2 = new TabPage();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(647, 754);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(96, 118, 85);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(textBox6);
            tabPage1.Controls.Add(textBox5);
            tabPage1.Controls.Add(label6);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.RightToLeft = RightToLeft.Yes;
            tabPage1.Size = new Size(631, 700);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Авторизация";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 247, 233);
            button2.ForeColor = Color.FromArgb(96, 118, 85);
            button2.Location = new Point(179, 501);
            button2.Name = "button2";
            button2.Size = new Size(265, 46);
            button2.TabIndex = 10;
            button2.Text = "Войти";
            button2.UseVisualStyleBackColor = false;
            button2.Click += logIn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F);
            label7.ForeColor = Color.FromArgb(255, 247, 233);
            label7.Location = new Point(30, 249);
            label7.Name = "label7";
            label7.Size = new Size(136, 47);
            label7.TabIndex = 7;
            label7.Text = "пароль";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(30, 315);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(576, 39);
            textBox6.TabIndex = 6;
            textBox6.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(30, 170);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(576, 39);
            textBox5.TabIndex = 5;
            textBox5.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F);
            label6.ForeColor = Color.FromArgb(255, 247, 233);
            label6.Location = new Point(30, 97);
            label6.Name = "label6";
            label6.Size = new Size(112, 47);
            label6.TabIndex = 4;
            label6.Text = "логин";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(96, 118, 85);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(631, 700);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Регистрация";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 247, 233);
            button1.ForeColor = Color.FromArgb(96, 118, 85);
            button1.Location = new Point(176, 593);
            button1.Name = "button1";
            button1.Size = new Size(265, 46);
            button1.TabIndex = 9;
            button1.Text = "Зарегистрироваться";
            button1.UseVisualStyleBackColor = false;
            button1.Click += registration_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.ForeColor = Color.FromArgb(255, 247, 233);
            label5.Location = new Point(26, 426);
            label5.Name = "label5";
            label5.Size = new Size(136, 47);
            label5.TabIndex = 8;
            label5.Text = "пароль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.ForeColor = Color.FromArgb(255, 247, 233);
            label4.Location = new Point(26, 288);
            label4.Name = "label4";
            label4.Size = new Size(112, 47);
            label4.TabIndex = 7;
            label4.Text = "логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.ForeColor = Color.FromArgb(255, 247, 233);
            label3.Location = new Point(26, 166);
            label3.Name = "label3";
            label3.Size = new Size(163, 47);
            label3.TabIndex = 6;
            label3.Text = "фамилия";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(27, 230);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(576, 39);
            textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(27, 352);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(576, 39);
            textBox3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.ForeColor = Color.FromArgb(255, 247, 233);
            label2.Location = new Point(27, 36);
            label2.Name = "label2";
            label2.Size = new Size(83, 47);
            label2.TabIndex = 3;
            label2.Text = "имя";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 181);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(32, 491);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(576, 39);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(576, 39);
            textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(96, 118, 85);
            ClientSize = new Size(622, 754);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Registration";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox4;
        private TextBox textBox3;
        private Button button1;
        private Label label7;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label6;
        private Button button2;
    }
}
