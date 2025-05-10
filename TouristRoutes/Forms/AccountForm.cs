using TouristRoutes.Dtos;
using TouristRoutes.Forms;
using TouristRoutes.Services;

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

            _accountService = new AccountService();
        }

        /// <summary>
        /// Обработка нажатия на кнопку входа
        /// </summary>
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
                MessageBox.Show("Аутентификация прошла успешно!");

            }
            else
            {
                MessageBox.Show(result.Item2);
            }



        }

        /// <summary>
        /// Обработка нажатия на кнопку регистрации
        /// </summary>
        private void registration_Click(object sender, EventArgs e)
        {
            var registerDto = new RegisterDto
            {
                FirstName = registerFirstName.Text,
                LastName = registerLastName.Text,
                Email = registerEmail.Text,
                Password = registerPassword.Text
            };

            var result = _accountService.Register(registerDto);

            if (result.Item1)
            {
                MessageBox.Show("Регистрация прошла успешно!");

                this.Hide();
                AnketaForm anketaForm = new AnketaForm();
                anketaForm.Show();

            }
            else
            {
                MessageBox.Show(result.Item2);
            }
        }
    }
}
