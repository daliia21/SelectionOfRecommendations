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
            label4 = new Label();
            passwordRepeatTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
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
            registerTabPage.Controls.Add(label4);
            registerTabPage.Controls.Add(passwordRepeatTextBox);
            registerTabPage.Controls.Add(label3);
            registerTabPage.Controls.Add(label2);
            registerTabPage.Controls.Add(label1);
            registerTabPage.Controls.Add(registerButton);
            registerTabPage.Controls.Add(registerPasswordLabel);
            registerTabPage.Controls.Add(registerEmailLabel);
            registerTabPage.Controls.Add(registerLastNameLabel);
            registerTabPage.Controls.Add(registerLastName);
            registerTabPage.Controls.Add(registerEmail);
            registerTabPage.Controls.Add(registerPassword);
            registerTabPage.Controls.Add(registerFirstName);
            registerTabPage.Controls.Add(registerFirstNameLabel);
            registerTabPage.Location = new Point(4, 24);
            registerTabPage.Margin = new Padding(2, 1, 2, 1);
            registerTabPage.Name = "registerTabPage";
            registerTabPage.Padding = new Padding(2, 1, 2, 1);
            registerTabPage.Size = new Size(502, 466);
            registerTabPage.TabIndex = 1;
            registerTabPage.Text = "Регистрация";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = Color.FromArgb(255, 247, 233);
            label4.Location = new Point(14, 318);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(181, 28);
            label4.TabIndex = 14;
            label4.Text = "повторите пароль";
            // 
            // passwordRepeatTextBox
            // 
            passwordRepeatTextBox.Location = new Point(14, 352);
            passwordRepeatTextBox.Margin = new Padding(2, 1, 2, 1);
            passwordRepeatTextBox.MaxLength = 52;
            passwordRepeatTextBox.Name = "passwordRepeatTextBox";
            passwordRepeatTextBox.Size = new Size(473, 23);
            passwordRepeatTextBox.TabIndex = 13;
            passwordRepeatTextBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(14, 285);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(297, 15);
            label3.TabIndex = 12;
            label3.Text = "символы. Минимальная длина пароля - 8 символов";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 270);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(440, 15);
            label2.TabIndex = 11;
            label2.Text = "Пароль должен содержать строчные, заглавные буквы, цифры, специальные ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 182);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(372, 15);
            label1.TabIndex = 10;
            label1.Text = "Логин должен быть следующего формата: IvanovIvan@gmail.com";
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.FromArgb(255, 247, 233);
            registerButton.Font = new Font("Segoe UI", 13F);
            registerButton.ForeColor = Color.FromArgb(96, 118, 85);
            registerButton.Location = new Point(115, 410);
            registerButton.Margin = new Padding(2, 1, 2, 1);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(283, 39);
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
            registerPasswordLabel.Location = new Point(15, 215);
            registerPasswordLabel.Margin = new Padding(2, 0, 2, 0);
            registerPasswordLabel.Name = "registerPasswordLabel";
            registerPasswordLabel.Size = new Size(79, 28);
            registerPasswordLabel.TabIndex = 8;
            registerPasswordLabel.Text = "пароль";
            // 
            // registerEmailLabel
            // 
            registerEmailLabel.AutoSize = true;
            registerEmailLabel.Font = new Font("Segoe UI", 15F);
            registerEmailLabel.ForeColor = Color.FromArgb(255, 247, 233);
            registerEmailLabel.Location = new Point(15, 130);
            registerEmailLabel.Margin = new Padding(2, 0, 2, 0);
            registerEmailLabel.Name = "registerEmailLabel";
            registerEmailLabel.Size = new Size(67, 28);
            registerEmailLabel.TabIndex = 7;
            registerEmailLabel.Text = "логин";
            // 
            // registerLastNameLabel
            // 
            registerLastNameLabel.AutoSize = true;
            registerLastNameLabel.Font = new Font("Segoe UI", 15F);
            registerLastNameLabel.ForeColor = Color.FromArgb(255, 247, 233);
            registerLastNameLabel.Location = new Point(14, 70);
            registerLastNameLabel.Margin = new Padding(2, 0, 2, 0);
            registerLastNameLabel.Name = "registerLastNameLabel";
            registerLastNameLabel.Size = new Size(95, 28);
            registerLastNameLabel.TabIndex = 6;
            registerLastNameLabel.Text = "фамилия";
            // 
            // registerLastName
            // 
            registerLastName.Location = new Point(15, 97);
            registerLastName.Margin = new Padding(2, 1, 2, 1);
            registerLastName.MaxLength = 52;
            registerLastName.Name = "registerLastName";
            registerLastName.Size = new Size(476, 23);
            registerLastName.TabIndex = 5;
            // 
            // registerEmail
            // 
            registerEmail.Location = new Point(15, 157);
            registerEmail.Margin = new Padding(2, 1, 2, 1);
            registerEmail.MaxLength = 52;
            registerEmail.Name = "registerEmail";
            registerEmail.Size = new Size(476, 23);
            registerEmail.TabIndex = 4;
            // 
            // registerPassword
            // 
            registerPassword.Location = new Point(17, 241);
            registerPassword.Margin = new Padding(2, 1, 2, 1);
            registerPassword.MaxLength = 52;
            registerPassword.Name = "registerPassword";
            registerPassword.Size = new Size(473, 23);
            registerPassword.TabIndex = 1;
            registerPassword.UseSystemPasswordChar = true;
            // 
            // registerFirstName
            // 
            registerFirstName.Location = new Point(15, 37);
            registerFirstName.Margin = new Padding(2, 1, 2, 1);
            registerFirstName.MaxLength = 52;
            registerFirstName.Name = "registerFirstName";
            registerFirstName.Size = new Size(476, 23);
            registerFirstName.TabIndex = 0;
            // 
            // registerFirstNameLabel
            // 
            registerFirstNameLabel.AutoSize = true;
            registerFirstNameLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            registerFirstNameLabel.ForeColor = Color.FromArgb(255, 247, 233);
            registerFirstNameLabel.Location = new Point(14, 10);
            registerFirstNameLabel.Margin = new Padding(2, 0, 2, 0);
            registerFirstNameLabel.Name = "registerFirstNameLabel";
            registerFirstNameLabel.Size = new Size(48, 28);
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
            loginTabPage.Location = new Point(4, 24);
            loginTabPage.Margin = new Padding(2, 1, 2, 1);
            loginTabPage.Name = "loginTabPage";
            loginTabPage.Padding = new Padding(2, 1, 2, 1);
            loginTabPage.Size = new Size(502, 466);
            loginTabPage.TabIndex = 0;
            loginTabPage.Text = "Вход";
            // 
            // loginPasswordLabel
            // 
            loginPasswordLabel.AutoSize = true;
            loginPasswordLabel.Font = new Font("Segoe UI", 15F);
            loginPasswordLabel.ForeColor = Color.FromArgb(255, 247, 233);
            loginPasswordLabel.Location = new Point(13, 217);
            loginPasswordLabel.Margin = new Padding(2, 0, 2, 0);
            loginPasswordLabel.Name = "loginPasswordLabel";
            loginPasswordLabel.Size = new Size(79, 28);
            loginPasswordLabel.TabIndex = 14;
            loginPasswordLabel.Text = "пароль";
            // 
            // loginEmailLabel
            // 
            loginEmailLabel.AutoSize = true;
            loginEmailLabel.Font = new Font("Segoe UI", 15F);
            loginEmailLabel.ForeColor = Color.FromArgb(255, 247, 233);
            loginEmailLabel.Location = new Point(13, 120);
            loginEmailLabel.Margin = new Padding(2, 0, 2, 0);
            loginEmailLabel.Name = "loginEmailLabel";
            loginEmailLabel.Size = new Size(67, 28);
            loginEmailLabel.TabIndex = 13;
            loginEmailLabel.Text = "логин";
            // 
            // loginEmail
            // 
            loginEmail.Location = new Point(13, 152);
            loginEmail.Margin = new Padding(2, 1, 2, 1);
            loginEmail.MaxLength = 52;
            loginEmail.Name = "loginEmail";
            loginEmail.Size = new Size(476, 23);
            loginEmail.TabIndex = 12;
            // 
            // loginPassword
            // 
            loginPassword.Location = new Point(13, 252);
            loginPassword.Margin = new Padding(2, 1, 2, 1);
            loginPassword.MaxLength = 52;
            loginPassword.Name = "loginPassword";
            loginPassword.Size = new Size(476, 23);
            loginPassword.TabIndex = 11;
            loginPassword.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(255, 247, 233);
            loginButton.Font = new Font("Segoe UI", 13F);
            loginButton.ForeColor = Color.FromArgb(96, 118, 85);
            loginButton.Location = new Point(107, 366);
            loginButton.Margin = new Padding(2, 1, 2, 1);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(283, 39);
            loginButton.TabIndex = 10;
            loginButton.Text = "ВОЙТИ";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += logIn_Click;
            // 
            // accountFormTabControl
            // 
            accountFormTabControl.Controls.Add(loginTabPage);
            accountFormTabControl.Controls.Add(registerTabPage);
            accountFormTabControl.Location = new Point(-6, 6);
            accountFormTabControl.Margin = new Padding(2, 1, 2, 1);
            accountFormTabControl.Name = "accountFormTabControl";
            accountFormTabControl.SelectedIndex = 0;
            accountFormTabControl.Size = new Size(510, 494);
            accountFormTabControl.SizeMode = TabSizeMode.Fixed;
            accountFormTabControl.TabIndex = 4;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(96, 118, 85);
            ClientSize = new Size(495, 478);
            Controls.Add(accountFormTabControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 1, 2, 1);
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
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox passwordRepeatTextBox;
    }
}
