using Microsoft.EntityFrameworkCore;
using TouristRoutes;
using TouristRoutes.Models;

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

            //// ���������� 2 ������������� � ������ ��� ������ �� ���
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
            //    AgeCategory = "�� 12 �� 20",
            //    AppUser = Dalia,
            //    Budget = "45000",
            //    DurationOfTheTrip = "����� �������",
            //    FrequentLocation = "����� �������",
            //    LevelOfTraining = "����� �������",
            //    Season = "����",
            //    TypeOfTourism = "����� �������"
            //});

            //dbContext.SaveChanges();




            // ����� ������� ������������ � id 3 ��� AppUserInfo

            //var user = dbContext.Users.Find(3);




            // ����� ������� ������������ � id 3 � AppUserInfo

            //var user = dbContext.Users
            //    .Where(u => u.Id == 4)
            //    .Include(u => u.AppUserInfo)
            //    .FirstOrDefault();


            // �������� ������������ � id ������ 3

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

            // �������� ���� �������������
        }
    }
}