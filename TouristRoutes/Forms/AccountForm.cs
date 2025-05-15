using NLog;
using TouristRoutes.Dtos;
using TouristRoutes.Forms;
using TouristRoutes.Services;
using static TouristRoutes.Properties.Resources;

namespace TouristRoutes
{
    /// <summary>
    /// Форма входа/регистрации
    /// </summary>
    public partial class AccountForm : Form
    {
        AccountService _accountService;

        /// <summary>
        /// Конструктор формы входа/регистрации
        /// </summary>
        public AccountForm()
        {
            InitializeComponent();

            Program.Logger.Info("Форма аккаунта загрузилась");

            _accountService = new AccountService();
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            var loginDto = new LoginDto
            {
                Email = loginEmail.Text,
                Password = loginPassword.Text
            };

            var result = _accountService.Login(loginDto);

            if (result.Item1)
            {
                MessageBox.Show(AuthMessage);
                this.Hide();
                var recomendationForm = new RecommendationsListForm();
                recomendationForm.Show();
            }
            else
            {
                MessageBox.Show(result.Item2);
            }
        }


        private void registration_Click(object sender, EventArgs e)
        {
            var registerDto = new RegisterDto
            {
                FirstName = registerFirstName.Text,
                LastName = registerLastName.Text,
                Email = registerEmail.Text,
                Password = registerPassword.Text,
                RepeatPassword = passwordRepeatTextBox.Text
            };


            var result = _accountService.Register(registerDto);

            if (result.Item1)
            {
                MessageBox.Show(RegisterMessage);

                this.Hide();
                var anketaForm = new AnketaForm();
                anketaForm.Show();
            }
            else
            {
                MessageBox.Show(result.Item2);
            }
        }

        private void loginEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void registerFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void registerLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void registerEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void loginPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void registerPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void passwordRepeatTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
