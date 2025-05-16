using System.Text.RegularExpressions;
using TouristRoutes.Dtos;
using TouristRoutes.Models;
using static BCrypt.Net.BCrypt;
using static TouristRoutes.Properties.Resources;

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

            if (!CheckFillFields(registerDto))
            {
                return (false, FieldsNotFillMessage);
            }

            if (dbUser != null)
            {
                return (false, EmailRepeatMessage);
            }

            if (!CheckCorrectEmail(registerDto.Email))
            {
                return (false, EmailUncorrectMessage);
            }

            if (!CheckComplexityPassword(registerDto.Password))
            {
                return (false, PasswordUnsecureMessage);
            }           

            if (!CheckCoincidencePasswords(registerDto.Password, registerDto.RepeatPassword))
            {
                return (false, PasswordUncoincidenceMessage);
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

            return (true, string.Empty);
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
                return (false, UserUnloggedMessage);
            }

            if (dbTags.Count != tags.Count)
            {
                return (false, TagsNotFindMessage);
            }

            foreach (var tag in dbTags)
            {
                var exists = _dbContext.UserInfoTags
                    .Any(ut => ut.AppUserId == currentUser.Id && ut.TagId == tag.Id);

                if (!exists)
                {
                    _dbContext.UserInfoTags.Add(new AppUserTag
                    {
                        AppUserId = currentUser.Id,
                        TagId = tag.Id
                    });
                }
            }

            _dbContext.SaveChanges();

            return (true, "Ok");
        }

        /// <summary>
        /// Метод для получения тегов текущего пользователя
        /// </summary>
        public List<Tag> GetAllTagsForCurrentUser()
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
            string specialSymbols = SpecialSymbols;
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

        private bool CheckCoincidencePasswords(string pass1, string pass2)
        {
            if (pass1 != pass2)
            {
                return false;
            }
            return true;
        }

        private bool CheckFillFields(RegisterDto registerDto)
        {
            if (registerDto.FirstName == string.Empty || registerDto.LastName == string.Empty
                || registerDto.Email == string.Empty || registerDto.Password == string.Empty
                || registerDto.RepeatPassword == string.Empty)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Метод для входа
        /// </summary>
        public (bool, string) Login(LoginDto loginDto)
        {
            var dbUser = _dbContext.Users
                .FirstOrDefault(u => u.Email == loginDto.Email);
                

            if (!CheckFillFields(loginDto))
            {
                return (false, FieldsNotFillMessage);
            }
            if (dbUser == null)
            {
                return (false, UserUnregisterMessage);
            }



            var isValid = Verify(loginDto.Password, dbUser.PasswordHash);

            if (isValid)
            {
                AppState.IsAuthenticated = true;
                AppState.CurrentAppUser = dbUser;
                AppState.IsAdmin = dbUser.IsAdmin;

                return (true, string.Empty);
            } else
            {
                return (false, PasswordInvalidMessage);
            }
        }

        private bool CheckFillFields(LoginDto loginDto)
        {
            if (loginDto.Email == string.Empty || loginDto.Password == string.Empty)
            {
                return false;
            }
            return true;
        }


    }
}
