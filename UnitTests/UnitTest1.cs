using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using TouristRoutes;
using TouristRoutes.Dtos;
using TouristRoutes.Forms;
using TouristRoutes.Models;
using TouristRoutes.Services;
using Xunit;


namespace UnitTests
{
    public class UnitTest1
    {
        AccountService acc = new AccountService();
        private readonly AppDbContext _dbCont;
        private readonly AccountService _accdb;

        [Fact]
        public void Route_CreateWithValidData_ShouldInitializeProperties()
        {
            var route = new Route
            {
                Id = 1,
                RouteName = "������ ����� �� �������",
                RoutePrice = "15000 ���.",
                RouteLocation = "������",
                RouteDuration = "7 ����",
                LevelOfTraining = "�������",
                RouteDescription = "������������� ����� � ����� �� �������",
                RouteImagePath = "images/elbrus.jpg"
            };

            // Act (�������� - � ������ ������ ������ �������� �������)

            // Assert (��������)
            Assert.Equal(1, route.Id);
            Assert.Equal("������ ����� �� �������", route.RouteName);
            Assert.Equal("15000 ���.", route.RoutePrice);
            Assert.Equal("������", route.RouteLocation);
            Assert.Equal("7 ����", route.RouteDuration);
            Assert.Equal("�������", route.LevelOfTraining);
            Assert.Equal("������������� ����� � ����� �� �������", route.RouteDescription);
            Assert.Equal("images/elbrus.jpg", route.RouteImagePath);
            Assert.Empty(route.RouteTags); // ���������, ��� ������ ����� ���� ��� ��������
        }

        [Fact]
        public void LogIn1()
        {
            AccountService acc = new AccountService();

            var loginDto = new LoginDto
            { 
                Email = "whkebfowuenf",
                Password = "wkjejfnweof"
            };

            var result = acc.Login(loginDto);
            string message;

            if (result.Item1)
            {
                message = Properties.Resources.AuthMessage;
            }
            else
            {
                message = result.Item2;         
            }
  
            Assert.NotEqual(message, Properties.Resources.AuthMessage);
        }

        [Fact]
        public void LogIn2()
        {
            AccountService acc = new AccountService();

            var loginDto = new LoginDto
            {
                Email = "",
                Password = "ANnn23!f"
            };

            var result = acc.Login(loginDto);
            string message;

            if (result.Item1)
            {
                message = Properties.Resources.AuthMessage;
            }
            else
            {
                message = result.Item2;
            }

            Assert.NotEqual(message, Properties.Resources.AuthMessage);
        }

        [Fact]
        public void LogIn3()
        {
            AccountService acc = new AccountService();

            var loginDto = new LoginDto
            {
                Email = "ammin@gmail.com",
                Password = ""
            };

            var result = acc.Login(loginDto);
            string message;

            if (result.Item1)
            {
                message = Properties.Resources.AuthMessage;
            }
            else
            {
                message = result.Item2;
            }

            Assert.NotEqual(message, Properties.Resources.AuthMessage);
        }


        [Fact]
        public void LogIn4()
        {
            AccountService acc = new AccountService();
            // Arrange
            var loginDto = new LoginDto
            {
                Email = "test@gmail.com",
                Password = "Test123!"
            };

            // Act
            var result = acc.Login(loginDto);

            // Assert
            Assert.False(result.Item1);
            //Assert.Empty(result.Item2);
        }

        [Fact]
        public void Register1()
        {
            AccountService acc = new AccountService();

            var registerDto = new RegisterDto
            {
                FirstName = "",
                LastName = "",
                Email = "",
                Password = "",
                RepeatPassword = ""
            };

            var result = acc.Register(registerDto);
            string message;

            if (result.Item1)
            {
                message = Properties.Resources.RegisterMessage;
            }
            else
            {
                message = result.Item2;
            }

            Assert.NotEqual(message, Properties.Resources.RegisterMessage);
        }

        [Fact]
        public void Register2()
        {
            AccountService acc = new AccountService();

            var registerDto = new RegisterDto
            {
                FirstName = "�����",
                LastName = "������",
                Email = "amm@gmaio.com",
                Password = "eprkmgekprmg",
                RepeatPassword = "eprkmgekprmg"
            };

            var result = acc.Register(registerDto);
            string message;

            if (result.Item1)
            {
                message = Properties.Resources.RegisterMessage;
            }
            else
            {
                message = result.Item2;
            }

            Assert.NotEqual(message, Properties.Resources.RegisterMessage);
        }

        [Fact]
        public void Register3()
        {
            AccountService acc = new AccountService();

            var registerDto = new RegisterDto
            {
                FirstName = "jelkjrvoipekr",
                LastName = "eropvkeporkg",
                Email = "eporkeporkgoperkg",
                Password = "22AAaa!!mad",
                RepeatPassword = "22AAaa!!mad"
            };

            var result = acc.Register(registerDto);
            string message;

            if (result.Item1)
            {
                message = Properties.Resources.RegisterMessage;
            }
            else
            {
                message = result.Item2;
            }

            Assert.NotEqual(message, Properties.Resources.RegisterMessage);
        }

        [Fact]
        public void Register4()
        {
            AccountService acc = new AccountService();

            var registerDto = new RegisterDto
            {
                FirstName = "",
                LastName = "jeorlngeorg",
                Email = "wkeprkmeprmg",
                Password = "22AAaa!!mad",
                RepeatPassword = "22AAaa!!mad"
            };

            var result = acc.Register(registerDto);
            string message;

            if (result.Item1)
            {
                message = Properties.Resources.RegisterMessage;
            }
            else
            {
                message = result.Item2;
            }

            Assert.NotEqual(message, Properties.Resources.RegisterMessage);
        }

        [Fact]
        public void Register5()
        {
            AccountService acc = new AccountService();

            var registerDto = new RegisterDto
            {
                FirstName = "22AAaa!!mad",
                LastName = "",
                Email = "DAMaD@gmail.com",
                Password = "22AAaa!!mad",
                RepeatPassword = "22AAaa!!mad"
            };

            var result = acc.Register(registerDto);
            string message;

            if (result.Item1)
            {
                message = Properties.Resources.RegisterMessage;
            }
            else
            {
                message = result.Item2;
            }

            Assert.NotEqual(message, Properties.Resources.RegisterMessage);
        }

        [Fact]
        public void Register6()
        {
            AccountService acc = new AccountService();

            var registerDto = new RegisterDto
            {
                FirstName = "Andrey",
                LastName = "Mingalev",
                Email = "DAMad@gmail.com",
                Password = "22AAaa!!mad",
                RepeatPassword = "22AAaa!!mad"
            };

            var result = acc.Register(registerDto);
            string message;

            if (result.Item1)
            {
                message = Properties.Resources.RegisterMessage;
            }
            else
            {
                message = result.Item2;
            }

            Assert.NotEqual(message, Properties.Resources.RegisterMessage);
        }

        [Fact]
        public void Constructor_AnketaForm()
        {
            // Arrange & Act
            var form = new AnketaForm();

            // Assert
            Assert.NotNull(form.Controls.Find("ageGroupBox", true)[0]);
            Assert.NotNull(form.Controls.Find("budgetGroupBox", true)[0]);
            Assert.NotNull(form.Controls.Find("durationGroupBox", true)[0]);
            Assert.NotNull(form.Controls.Find("levelOfTrainingGroupBox", true)[0]);
            Assert.NotNull(form.Controls.Find("locationGroupBox", true)[0]);
            Assert.NotNull(form.Controls.Find("purposeGroupBox", true)[0]);
            Assert.NotNull(form.Controls.Find("seasonGroupBox", true)[0]);
            Assert.NotNull(form.Controls.Find("typeOfTourismGroupBox", true)[0]);
        }

        [Fact]
        public void Constructor_AccountForm()
        {
            // Arrange & Act
            var form = new AccountForm();

            // Assert
            Assert.NotNull(form.Controls.Find("loginEmail", true)[0]);
            Assert.NotNull(form.Controls.Find("loginPassword", true)[0]);
            Assert.NotNull(form.Controls.Find("registerFirstName", true)[0]);
            Assert.NotNull(form.Controls.Find("registerLastName", true)[0]);
            Assert.NotNull(form.Controls.Find("registerEmail", true)[0]);
            Assert.NotNull(form.Controls.Find("registerPassword", true)[0]);
            Assert.NotNull(form.Controls.Find("passwordRepeatTextBox", true)[0]);
            Assert.NotNull(form.Controls.Find("logIn", true)[0]);
            Assert.NotNull(form.Controls.Find("registration", true)[0]);
        }

        


    }
}