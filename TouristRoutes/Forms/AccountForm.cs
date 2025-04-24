using TouristRoutes.Dtos;
using TouristRoutes.Forms;
using TouristRoutes.Services;

namespace TouristRoutes
{
    public partial class AccountForm : Form
    {
        AccountService _accountService;

        public AccountForm()
        {
            InitializeComponent();

            _accountService = new AccountService();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void logIn_Click(object sender, EventArgs e)
        {
            LoginDto loginDto = new LoginDto
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

        private void registration_Click(object sender, EventArgs e)
        {
            RegisterDto registerDto = new RegisterDto
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

            } else
            {
                MessageBox.Show(result.Item2);
            }

            
        }
    }
}
