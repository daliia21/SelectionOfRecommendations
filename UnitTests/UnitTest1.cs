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
            // Arrange (подготовка данных)
            var route = new Route
            {
                Id = 1,
                RouteName = "Горный поход на Эльбрус",
                RoutePrice = "15000 руб.",
                RouteLocation = "Кавказ",
                RouteDuration = "7 дней",
                LevelOfTraining = "Средний",
                RouteDescription = "Захватывающий поход с видом на вершины",
                RouteImagePath = "images/elbrus.jpg"
            };

            // Act (действие - в данном случае просто создание объекта)

            // Assert (проверка)
            Assert.Equal(1, route.Id);
            Assert.Equal("Горный поход на Эльбрус", route.RouteName);
            Assert.Equal("15000 руб.", route.RoutePrice);
            Assert.Equal("Кавказ", route.RouteLocation);
            Assert.Equal("7 дней", route.RouteDuration);
            Assert.Equal("Средний", route.LevelOfTraining);
            Assert.Equal("Захватывающий поход с видом на вершины", route.RouteDescription);
            Assert.Equal("images/elbrus.jpg", route.RouteImagePath);
            Assert.Empty(route.RouteTags); // Проверяем, что список тегов пуст при создании
        }

        [Fact]
        public void My_AccountService()
        {
            var acc = new AccountService();

        }
    }
}