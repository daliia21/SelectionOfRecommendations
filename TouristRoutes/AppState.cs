using TouristRoutes.Models;

namespace TouristRoutes
{
    /// <summary>
    /// Класс для хранения информации о текущем пользователе
    /// </summary>
    public static class AppState
    {
        /// <summary>
        /// Метка зарегистрировавшегося пользователя
        /// </summary>
        public static bool IsAuthenticated { get; set; } = false;

        /// <summary>
        /// Текущий пользователь
        /// </summary>
        public static AppUser? CurrentAppUser { get; set; } = null;

        /// <summary>
        /// Метка администратора
        /// </summary>
        public static bool IsAdmin { get; set; } = false;
    }
}
