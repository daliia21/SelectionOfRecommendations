using Microsoft.VisualBasic.ApplicationServices;
using System.Text.RegularExpressions;
using TouristRoutes.Dtos;
using TouristRoutes.Models;
using static BCrypt.Net.BCrypt;

namespace TouristRoutes.Services
{
    /// <summary>
    /// Сервис для входа/регистрации
    /// </summary>
    public class AccountService
    {
        private AppDbContext _dbContext;

        /// <summary>
        /// Конструтор сервиса
        /// </summary>
        public AccountService()
        {
            _dbContext = new AppDbContext();
        }

        /// <summary>
        /// Метод для регистрации
        /// </summary>
        public (bool, string) Register(RegisterDto registerDto)
        {
            var dbUser = _dbContext.Users
                .Where(u => u.Email == registerDto.Email)
                .FirstOrDefault();

            if (dbUser != null)
            {
                return (false, "Пользователь с таким email уже есть");
            }

            if (!CheckComplexityPassword(registerDto.Password))
            {
                return (false, "Ненадежный пароль");
            }

            if (!CheckCorrectEmail(registerDto.Email))
            {
                return (false, "Неправильный формат email");
            }

            var user = new AppUser
            {
                FirstName = registerDto.FirstName,
                LastName = registerDto.LastName,
                Email = registerDto.Email,
                PasswordHash = HashPassword(registerDto.Password, GenerateSalt(12))
            };

            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();

            AppState.IsAuthenticated = true;
            AppState.CurrentAppUser = user;

            return (true, "");
        }

        /// <summary>
        /// Метод для добавления тегов пользователя
        /// </summary>
        public (bool, string) AddTags(List<string> tags)
        {
            var dbTags = _dbContext.Tags
                .Where(t => tags.Contains(t.TagName))
                .ToList();

            var currentUser = AppState.CurrentAppUser;

            if (currentUser == null)
            {
                return (false, "Текущий пользователь не вошел в систему");
            }

            if (dbTags.Count != tags.Count)
            {
                return (false, "Не все теги найдены");
            }

            foreach (var tag in dbTags)
            {
                if (!currentUser.UserTags.Any(ut => ut.TagId == tag.Id))
                {
                    currentUser.UserTags.Add(new AppUserTag
                    {
                        AppUserId = currentUser.Id,
                        TagId = tag.Id
                    });
                }
            }

            _dbContext.SaveChanges();

            return (true, "Ok");
        }

        public List<Tag> GetAllCurrentUserTags()
        {            
            var currentUser = AppState.CurrentAppUser;
            var userId = currentUser.Id;

            var tagIds = _dbContext.UserInfoTags
                .Where(ut => ut.AppUserId == userId)
                .Select(ut => ut.TagId)
                .ToList();

            var tags = _dbContext.Tags
                .Where(t => tagIds.Contains(t.Id))
                .ToList();

            return tags;
        }

        
        private bool CheckComplexityPassword(string password)
        {
            string specialSymbols = "!@#$%^&*()~`;:?";
            if (password.Length < 8)
            {
                return false;
            }

            if (!password.Any(char.IsLower))
            {
                return false;
            }

            if (!password.Any(char.IsUpper))
            {
                return false;
            }

            if (!password.Any(char.IsDigit))
            {
                return false;
            }

            if (!password.Any(c => specialSymbols.Contains(c)))
            {
                return false;
            }

                
            return true;
        }

        private bool CheckCorrectEmail(string email)
        {                                     
            var pattern = @"^(([a-zA-Z0-9_\-\.%\+]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,})|("".+"")@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,}))$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// Метод для входа
        /// </summary>
        public (bool, string) Login(LoginDto loginDto)
        {
            var dbUser = _dbContext.Users
                .Where(u => u.Email == loginDto.Email)
                .FirstOrDefault();

            if (dbUser == null)
            {
                return (false, "Нет такого пользователя");
            }


            var isValid = Verify(loginDto.Password, dbUser.PasswordHash);

            if (isValid)
            {
                AppState.IsAuthenticated = true;
                AppState.CurrentAppUser = dbUser;
                AppState.IsAdmin = dbUser.IsAdmin;

                return (true, "");
            } else
            {
                return (false, "Неверный пароль");
            }
        }
    }
}
