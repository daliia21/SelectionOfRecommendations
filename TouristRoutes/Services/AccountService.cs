using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TouristRoutes.Dtos;
using TouristRoutes.Models;
using static BCrypt.Net.BCrypt;

namespace TouristRoutes.Services
{
    public class AccountService
    {
        private AppDbContext _dbContext;
        public AccountService()
        {
            _dbContext = new AppDbContext();
        }

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
            try
            {               
                string pattern = @"^(([a-zA-Z0-9_\-\.%\+]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,})|("".+"")@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,}))$";
                return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
            }
            catch
            {
                return false;
            }

        }

        public (bool, string) Login(LoginDto loginDto)
        {
            var dbUser = _dbContext.Users
                .Where(u => u.Email == loginDto.Email)
                .FirstOrDefault();

            if (dbUser == null)
            {
                return (false, "Нет такого пользователя");
            }


            bool isValid = Verify(loginDto.Password, dbUser.PasswordHash);

            if (isValid)
            {
                AppState.IsAuthenticated = true;
                AppState.CurrentAppUser = dbUser;

                return (true, "");
            } else
            {
                return (false, "Неверный пароль");
            }
        }
    }
}
