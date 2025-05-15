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

            Program.Logger.Info(AccountFormLoadLog);

            _accountService = new AccountService();

            loginEmail.KeyPress += BlockWhiteSpace_KeyPress;
            registerFirstName.KeyPress += BlockWhiteSpace_KeyPress;
            registerLastName.KeyPress += BlockWhiteSpace_KeyPress;
            registerEmail.KeyPress += BlockWhiteSpace_KeyPress;
            loginPassword.KeyPress += BlockWhiteSpace_KeyPress;
            registerPassword.KeyPress += BlockWhiteSpace_KeyPress;
            passwordRepeatTextBox.KeyPress += BlockWhiteSpace_KeyPress;
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

        private void BlockWhiteSpace_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
