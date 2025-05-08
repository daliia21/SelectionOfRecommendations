using Microsoft.EntityFrameworkCore;
using TouristRoutes;
using TouristRoutes.Dtos;
using TouristRoutes.Services;

namespace SelectionOfRecomendationTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test()
        {

            AppDbContext dbContext = new AppDbContext();

            //var Dalia = new AppUser
            //{
            //    FirstName = "Dalia",
            //    LastName = "Sabirova",
            //    Email = "daliasabirova6@gmail.com",
            //    PasswordHash = "12345"
            //};

            //// Добавление 2 пользователей и анкету для одного из них
            //dbContext.Users.Add(Dalia);

            //dbContext.Users.Add(new AppUser
            //{
            //    FirstName = "Kamil",
            //    LastName = "Sabirov",
            //    Email = "kamil6@gmail.com",
            //    PasswordHash = "543231"
            //});

            //dbContext.UserInfos.Add(new AppUserInfo
            //{
            //    AgeCategory = "от 12 до 20",
            //    AppUser = Dalia,
            //    Budget = "45000",
            //    DurationOfTheTrip = "Очень опытный",
            //    FrequentLocation = "Очень опытный",
            //    LevelOfTraining = "Очень опытный",
            //    Season = "луто",
            //    TypeOfTourism = "Очень опытный"
            //});

            //dbContext.SaveChanges();




            // Нужно извлечь пользователя с id 3 без AppUserInfo

            //var user = dbContext.Users.Find(3);




            // Нужно извлечь пользователя с id 3 с AppUserInfo

            //var user = dbContext.Users
            //    .Where(u => u.Id == 4)
            //    .Include(u => u.AppUserInfo)
            //    .FirstOrDefault();


            // Удаления пользователя с id равным 3

            //var user = dbContext.Users.Find(3);

            //dbContext.Users.Remove(user);
            //dbContext.SaveChanges();


            //var user = dbContext.Users
            //    .Where(u => u.Id == 4)
            //    .Include(u => u.AppUserInfo)
            //    .FirstOrDefault();

            //if (user == null)
            //{
            //    return;
            //}

            //if (user.AppUserInfo != null)
            //{
            //    dbContext.UserInfos.Remove(user.AppUserInfo);
            //}

            //dbContext.Users.Remove(user);
            //dbContext.SaveChanges();

            // Удаление всех пользователей
        }

        [Fact]
        public void TestPasswordHasher()
        {
            AccountService accountService = new AccountService();

            //RegisterDto dalia = new RegisterDto
            //{
            //    FirstName = "Dalia",
            //    LastName = "Sabirova",
            //    Email = "daliaa@gmail.com",
            //    Password = "12345vbsln"
            //};

            //var result = accountService.Register(dalia);

            LoginDto loginDto = new LoginDto
            {
                Email = "dalia@gmail.com",
                Password = "12345vbsln"
            };

            var result = accountService.Login(loginDto);



        }

        [Fact]
        public void TagsTest()
        {
            using var context = new AppDbContext();

            var userTags = context.UserInfoTags
                .Where(ut => ut.AppUserId == 1)
                .Include(ut => ut.Tag)
                .Select(ut => ut.Tag)
                .ToList();

            int a = 2;
        }
    }
}