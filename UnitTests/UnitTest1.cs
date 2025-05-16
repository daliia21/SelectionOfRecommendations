using TouristRoutes.Models;
using TouristRoutes.Services;
using Xunit;


namespace UnitTests
{
    public class UnitTest1
    {

        [Fact]
        public void Route_CreateWithValidData_ShouldInitializeProperties()
        {
            // Arrange (���������� ������)
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
        public void My_AccountService()
        {
            var acc = new AccountService();

        }
    }
}