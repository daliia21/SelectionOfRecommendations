

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
        public int Id { get; set; }


        public List<AppUserTag> UserTags { get; set; } = new List<AppUserTag>();


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
        public string Email { get; set; }

        /// <summary>
        /// Пароль пользователя
        /// </summary>
        public string PasswordHash { get; set; }
    }
}
