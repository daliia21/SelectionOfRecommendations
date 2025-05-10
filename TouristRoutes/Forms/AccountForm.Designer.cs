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
            registerTabPage = new TabPage();
            registerButton = new Button();
            registerPasswordLabel = new Label();
            registerEmailLabel = new Label();
            registerLastNameLabel = new Label();
            registerLastName = new TextBox();
            registerEmail = new TextBox();
            registerPassword = new TextBox();
            registerFirstName = new TextBox();
            registerFirstNameLabel = new Label();
            loginTabPage = new TabPage();
            loginPasswordLabel = new Label();
            loginEmailLabel = new Label();
            loginEmail = new TextBox();
            loginPassword = new TextBox();
            loginButton = new Button();
            accountFormTabControl = new TabControl();
            registerTabPage.SuspendLayout();
            loginTabPage.SuspendLayout();
            accountFormTabControl.SuspendLayout();
            SuspendLayout();
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
            registerTabPage.Controls.Add(registerPassword);
            registerTabPage.Controls.Add(registerFirstName);
            registerTabPage.Controls.Add(registerFirstNameLabel);
            registerTabPage.Location = new Point(8, 46);
            registerTabPage.Name = "registerTabPage";
            registerTabPage.Padding = new Padding(3);
            registerTabPage.Size = new Size(931, 1000);
            registerTabPage.TabIndex = 1;
            registerTabPage.Text = "Регистрация";
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.FromArgb(255, 247, 233);
            registerButton.Font = new Font("Segoe UI", 13F);
            registerButton.ForeColor = Color.FromArgb(96, 118, 85);
            registerButton.Location = new Point(208, 802);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(525, 84);
            registerButton.TabIndex = 9;
            registerButton.Text = "ЗАРЕГИСТРИРОВАТЬСЯ";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registration_Click;
            // 
            // registerPasswordLabel
            // 
            registerPasswordLabel.AutoSize = true;
            registerPasswordLabel.Font = new Font("Segoe UI", 15F);
            registerPasswordLabel.ForeColor = Color.FromArgb(255, 247, 233);
            registerPasswordLabel.Location = new Point(26, 593);
            registerPasswordLabel.Name = "registerPasswordLabel";
            registerPasswordLabel.Size = new Size(154, 54);
            registerPasswordLabel.TabIndex = 8;
            registerPasswordLabel.Text = "пароль";
            // 
            // registerEmailLabel
            // 
            registerEmailLabel.AutoSize = true;
            registerEmailLabel.Font = new Font("Segoe UI", 15F);
            registerEmailLabel.ForeColor = Color.FromArgb(255, 247, 233);
            registerEmailLabel.Location = new Point(27, 414);
            registerEmailLabel.Name = "registerEmailLabel";
            registerEmailLabel.Size = new Size(128, 54);
            registerEmailLabel.TabIndex = 7;
            registerEmailLabel.Text = "логин";
            // 
            // registerLastNameLabel
            // 
            registerLastNameLabel.AutoSize = true;
            registerLastNameLabel.Font = new Font("Segoe UI", 15F);
            registerLastNameLabel.ForeColor = Color.FromArgb(255, 247, 233);
            registerLastNameLabel.Location = new Point(26, 243);
            registerLastNameLabel.Name = "registerLastNameLabel";
            registerLastNameLabel.Size = new Size(185, 54);
            registerLastNameLabel.TabIndex = 6;
            registerLastNameLabel.Text = "фамилия";
            // 
            // registerLastName
            // 
            registerLastName.Location = new Point(27, 308);
            registerLastName.Name = "registerLastName";
            registerLastName.Size = new Size(880, 39);
            registerLastName.TabIndex = 5;
            // 
            // registerEmail
            // 
            registerEmail.Location = new Point(27, 476);
            registerEmail.Name = "registerEmail";
            registerEmail.Size = new Size(880, 39);
            registerEmail.TabIndex = 4;
            // 
            // registerPassword
            // 
            registerPassword.Location = new Point(27, 656);
            registerPassword.Name = "registerPassword";
            registerPassword.Size = new Size(875, 39);
            registerPassword.TabIndex = 1;
            // 
            // registerFirstName
            // 
            registerFirstName.Location = new Point(27, 134);
            registerFirstName.Name = "registerFirstName";
            registerFirstName.Size = new Size(880, 39);
            registerFirstName.TabIndex = 0;
            // 
            // registerFirstNameLabel
            // 
            registerFirstNameLabel.AutoSize = true;
            registerFirstNameLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            registerFirstNameLabel.ForeColor = Color.FromArgb(255, 247, 233);
            registerFirstNameLabel.Location = new Point(26, 68);
            registerFirstNameLabel.Name = "registerFirstNameLabel";
            registerFirstNameLabel.Size = new Size(94, 54);
            registerFirstNameLabel.TabIndex = 3;
            registerFirstNameLabel.Text = "имя";
            // 
            // loginTabPage
            // 
            loginTabPage.BackColor = Color.FromArgb(96, 118, 85);
            loginTabPage.Controls.Add(loginPasswordLabel);
            loginTabPage.Controls.Add(loginEmailLabel);
            loginTabPage.Controls.Add(loginEmail);
            loginTabPage.Controls.Add(loginPassword);
            loginTabPage.Controls.Add(loginButton);
            loginTabPage.Location = new Point(8, 46);
            loginTabPage.Name = "loginTabPage";
            loginTabPage.Padding = new Padding(3);
            loginTabPage.Size = new Size(931, 1000);
            loginTabPage.TabIndex = 0;
            loginTabPage.Text = "Вход";
            // 
            // loginPasswordLabel
            // 
            loginPasswordLabel.AutoSize = true;
            loginPasswordLabel.Font = new Font("Segoe UI", 15F);
            loginPasswordLabel.ForeColor = Color.FromArgb(255, 247, 233);
            loginPasswordLabel.Location = new Point(25, 463);
            loginPasswordLabel.Name = "loginPasswordLabel";
            loginPasswordLabel.Size = new Size(154, 54);
            loginPasswordLabel.TabIndex = 14;
            loginPasswordLabel.Text = "пароль";
            // 
            // loginEmailLabel
            // 
            loginEmailLabel.AutoSize = true;
            loginEmailLabel.Font = new Font("Segoe UI", 15F);
            loginEmailLabel.ForeColor = Color.FromArgb(255, 247, 233);
            loginEmailLabel.Location = new Point(25, 257);
            loginEmailLabel.Name = "loginEmailLabel";
            loginEmailLabel.Size = new Size(128, 54);
            loginEmailLabel.TabIndex = 13;
            loginEmailLabel.Text = "логин";
            // 
            // loginEmail
            // 
            loginEmail.Location = new Point(25, 325);
            loginEmail.Name = "loginEmail";
            loginEmail.Size = new Size(880, 39);
            loginEmail.TabIndex = 12;
            // 
            // loginPassword
            // 
            loginPassword.Location = new Point(25, 537);
            loginPassword.Name = "loginPassword";
            loginPassword.Size = new Size(880, 39);
            loginPassword.TabIndex = 11;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(255, 247, 233);
            loginButton.Font = new Font("Segoe UI", 13F);
            loginButton.ForeColor = Color.FromArgb(96, 118, 85);
            loginButton.Location = new Point(198, 780);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(525, 84);
            loginButton.TabIndex = 10;
            loginButton.Text = "ВОЙТИ";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += logIn_Click;
            // 
            // accountFormTabControl
            // 
            accountFormTabControl.Controls.Add(loginTabPage);
            accountFormTabControl.Controls.Add(registerTabPage);
            accountFormTabControl.Location = new Point(-12, 12);
            accountFormTabControl.Name = "accountFormTabControl";
            accountFormTabControl.SelectedIndex = 0;
            accountFormTabControl.Size = new Size(947, 1054);
            accountFormTabControl.SizeMode = TabSizeMode.Fixed;
            accountFormTabControl.TabIndex = 4;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(96, 118, 85);
            ClientSize = new Size(932, 1064);
            Controls.Add(accountFormTabControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AccountForm";
            Text = "Регистрация/Вход";
            registerTabPage.ResumeLayout(false);
            registerTabPage.PerformLayout();
            loginTabPage.ResumeLayout(false);
            loginTabPage.PerformLayout();
            accountFormTabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage registerTabPage;
        private Button registerButton;
        private Label registerPasswordLabel;
        private Label registerEmailLabel;
        private Label registerLastNameLabel;
        private TextBox registerLastName;
        private TextBox registerEmail;
        private TextBox registerPassword;
        private TextBox registerFirstName;
        private Label registerFirstNameLabel;
        private TabPage loginTabPage;
        private Button loginButton;
        private TabControl accountFormTabControl;
        private Label loginPasswordLabel;
        private Label loginEmailLabel;
        private TextBox loginEmail;
        private TextBox loginPassword;
    }
}
