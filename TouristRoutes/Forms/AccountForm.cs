using TouristRoutes.Dtos;
using TouristRoutes.Forms;
using TouristRoutes.Services;

namespace TouristRoutes
{
    /// <summary>
    /// ����� �����/�����������
    /// </summary>
    public partial class AccountForm : Form
    {
        AccountService _accountService;

        /// <summary>
        /// ����������� ����� �����/�����������
        /// </summary>
        public AccountForm()
        {
            InitializeComponent();

            _accountService = new AccountService();
        }

        /// <summary>
        /// ��������� ������� �� ������ �����
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
                MessageBox.Show("�������������� ������ �������!");

            }
            else
            {
                MessageBox.Show(result.Item2);
            }



        }

        /// <summary>
        /// ��������� ������� �� ������ �����������
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
                MessageBox.Show("����������� ������ �������!");

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
