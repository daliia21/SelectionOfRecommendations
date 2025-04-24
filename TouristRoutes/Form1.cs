using TouristRoutes.Dtos;
using TouristRoutes.Services;

namespace TouristRoutes
{
    public partial class Form1 : Form
    {
        AccountService _accountService;

        public Form1()
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
                Email = textBox5.Text,
                Password = textBox6.Text
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
                FirstName = textBox1.Text,
                LastName = textBox4.Text,
                Email = textBox3.Text,
                Password = textBox2.Text
            };

            var result = _accountService.Register(registerDto);

            if (result.Item1)
            {
                MessageBox.Show("Регистрация прошла успешно!");

            } else
            {
                MessageBox.Show(result.Item2);
            }
        }
    }
}
