namespace TouristRoutes
{
    partial class AccountForm
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
            accountFormTabControl = new TabControl();
            loginTabPage = new TabPage();
            loginButton = new Button();
            loginPasswordLabel = new Label();
            loginPassword = new TextBox();
            loginEmail = new TextBox();
            loginEmailLabel = new Label();
            registerTabPage = new TabPage();
            registerButton = new Button();
            registerPasswordLabel = new Label();
            registerEmailLabel = new Label();
            registerLastNameLabel = new Label();
            registerLastName = new TextBox();
            registerEmail = new TextBox();
            label2 = new Label();
            registerPassword = new TextBox();
            registerFirstName = new TextBox();
            accountFormTabControl.SuspendLayout();
            loginTabPage.SuspendLayout();
            registerTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // accountFormTabControl
            // 
            accountFormTabControl.Controls.Add(loginTabPage);
            accountFormTabControl.Controls.Add(registerTabPage);
            accountFormTabControl.Location = new Point(-12, 12);
            accountFormTabControl.Name = "accountFormTabControl";
            accountFormTabControl.SelectedIndex = 0;
            accountFormTabControl.Size = new Size(647, 754);
            accountFormTabControl.SizeMode = TabSizeMode.Fixed;
            accountFormTabControl.TabIndex = 4;
            // 
            // loginTabPage
            // 
            loginTabPage.BackColor = Color.FromArgb(96, 118, 85);
            loginTabPage.Controls.Add(loginButton);
            loginTabPage.Controls.Add(loginPasswordLabel);
            loginTabPage.Controls.Add(loginPassword);
            loginTabPage.Controls.Add(loginEmail);
            loginTabPage.Controls.Add(loginEmailLabel);
            loginTabPage.Location = new Point(8, 46);
            loginTabPage.Name = "loginTabPage";
            loginTabPage.Padding = new Padding(3);
            loginTabPage.RightToLeft = RightToLeft.Yes;
            loginTabPage.Size = new Size(631, 700);
            loginTabPage.TabIndex = 0;
            loginTabPage.Text = "Авторизация";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(255, 247, 233);
            loginButton.ForeColor = Color.FromArgb(96, 118, 85);
            loginButton.Location = new Point(179, 501);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(265, 46);
            loginButton.TabIndex = 10;
            loginButton.Text = "Войти";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += logIn_Click;
            // 
            // loginPasswordLabel
            // 
            loginPasswordLabel.AutoSize = true;
            loginPasswordLabel.Font = new Font("Segoe UI", 13F);
            loginPasswordLabel.ForeColor = Color.FromArgb(255, 247, 233);
            loginPasswordLabel.Location = new Point(30, 249);
            loginPasswordLabel.Name = "loginPasswordLabel";
            loginPasswordLabel.Size = new Size(136, 47);
            loginPasswordLabel.TabIndex = 7;
            loginPasswordLabel.Text = "пароль";
            // 
            // loginPassword
            // 
            loginPassword.Location = new Point(30, 315);
            loginPassword.Name = "loginPassword";
            loginPassword.Size = new Size(576, 39);
            loginPassword.TabIndex = 6;
            loginPassword.TextAlign = HorizontalAlignment.Right;
            // 
            // loginEmail
            // 
            loginEmail.Location = new Point(30, 170);
            loginEmail.Name = "loginEmail";
            loginEmail.Size = new Size(576, 39);
            loginEmail.TabIndex = 5;
            loginEmail.TextAlign = HorizontalAlignment.Right;
            // 
            // loginEmailLabel
            // 
            loginEmailLabel.AutoSize = true;
            loginEmailLabel.Font = new Font("Segoe UI", 13F);
            loginEmailLabel.ForeColor = Color.FromArgb(255, 247, 233);
            loginEmailLabel.Location = new Point(30, 97);
            loginEmailLabel.Name = "loginEmailLabel";
            loginEmailLabel.Size = new Size(112, 47);
            loginEmailLabel.TabIndex = 4;
            loginEmailLabel.Text = "логин";
            // 
            // registerTabPage
            // 
            registerTabPage.BackColor = Color.FromArgb(96, 118, 85);
            registerTabPage.Controls.Add(registerButton);
            registerTabPage.Controls.Add(registerPasswordLabel);
            registerTabPage.Controls.Add(registerEmailLabel);
            registerTabPage.Controls.Add(registerLastNameLabel);
            registerTabPage.Controls.Add(registerLastName);
            registerTabPage.Controls.Add(registerEmail);
            registerTabPage.Controls.Add(label2);
            registerTabPage.Controls.Add(registerPassword);
            registerTabPage.Controls.Add(registerFirstName);
            registerTabPage.Location = new Point(8, 46);
            registerTabPage.Name = "registerTabPage";
            registerTabPage.Padding = new Padding(3);
            registerTabPage.Size = new Size(631, 700);
            registerTabPage.TabIndex = 1;
            registerTabPage.Text = "Регистрация";
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.FromArgb(255, 247, 233);
            registerButton.ForeColor = Color.FromArgb(96, 118, 85);
            registerButton.Location = new Point(176, 593);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(265, 46);
            registerButton.TabIndex = 9;
            registerButton.Text = "Зарегистрироваться";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registration_Click;
            // 
            // registerPasswordLabel
            // 
            registerPasswordLabel.AutoSize = true;
            registerPasswordLabel.Font = new Font("Segoe UI", 13F);
            registerPasswordLabel.ForeColor = Color.FromArgb(255, 247, 233);
            registerPasswordLabel.Location = new Point(26, 426);
            registerPasswordLabel.Name = "registerPasswordLabel";
            registerPasswordLabel.Size = new Size(136, 47);
            registerPasswordLabel.TabIndex = 8;
            registerPasswordLabel.Text = "пароль";
            // 
            // registerEmailLabel
            // 
            registerEmailLabel.AutoSize = true;
            registerEmailLabel.Font = new Font("Segoe UI", 13F);
            registerEmailLabel.ForeColor = Color.FromArgb(255, 247, 233);
            registerEmailLabel.Location = new Point(26, 288);
            registerEmailLabel.Name = "registerEmailLabel";
            registerEmailLabel.Size = new Size(112, 47);
            registerEmailLabel.TabIndex = 7;
            registerEmailLabel.Text = "логин";
            // 
            // registerLastNameLabel
            // 
            registerLastNameLabel.AutoSize = true;
            registerLastNameLabel.Font = new Font("Segoe UI", 13F);
            registerLastNameLabel.ForeColor = Color.FromArgb(255, 247, 233);
            registerLastNameLabel.Location = new Point(26, 166);
            registerLastNameLabel.Name = "registerLastNameLabel";
            registerLastNameLabel.Size = new Size(163, 47);
            registerLastNameLabel.TabIndex = 6;
            registerLastNameLabel.Text = "фамилия";
            // 
            // registerLastName
            // 
            registerLastName.Location = new Point(27, 230);
            registerLastName.Name = "registerLastName";
            registerLastName.Size = new Size(576, 39);
            registerLastName.TabIndex = 5;
            // 
            // registerEmail
            // 
            registerEmail.Location = new Point(27, 352);
            registerEmail.Name = "registerEmail";
            registerEmail.Size = new Size(576, 39);
            registerEmail.TabIndex = 4;
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
            // registerPassword
            // 
            registerPassword.Location = new Point(32, 491);
            registerPassword.Name = "registerPassword";
            registerPassword.Size = new Size(576, 39);
            registerPassword.TabIndex = 1;
            // 
            // registerFirstName
            // 
            registerFirstName.Location = new Point(27, 95);
            registerFirstName.Name = "registerFirstName";
            registerFirstName.Size = new Size(576, 39);
            registerFirstName.TabIndex = 0;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(96, 118, 85);
            ClientSize = new Size(622, 754);
            Controls.Add(accountFormTabControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AccountForm";
            Text = "Registration";
            accountFormTabControl.ResumeLayout(false);
            loginTabPage.ResumeLayout(false);
            loginTabPage.PerformLayout();
            registerTabPage.ResumeLayout(false);
            registerTabPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl accountFormTabControl;
        private TabPage loginTabPage;
        private TabPage registerTabPage;
        private Label label2;
        private TextBox registerPassword;
        private TextBox registerFirstName;
        private Label registerPasswordLabel;
        private Label registerEmailLabel;
        private Label registerLastNameLabel;
        private TextBox registerLastName;
        private TextBox registerEmail;
        private Button registerButton;
        private Label loginPasswordLabel;
        private TextBox loginPassword;
        private TextBox loginEmail;
        private Label loginEmailLabel;
        private Button loginButton;
    }
}
