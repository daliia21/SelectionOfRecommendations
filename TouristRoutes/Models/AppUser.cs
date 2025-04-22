using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristRoutes.Models
{
    /// <summary>
    /// Модель для хранения данных при регистрации
    /// <summary>
    public class AppUser
    {
        /// <summary>
        /// Id пользователя
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия пользователя
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Логин пользователя
        /// </summary>
        public string LogIn { get; set; }

        /// <summary>
        /// Пароль пользователя
        /// </summary>
        public string PasswordHash { get; set; }
    }
}
