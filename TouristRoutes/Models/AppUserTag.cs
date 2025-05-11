namespace TouristRoutes.Models
{
    /// <summary>
    /// Модель для хранения тегов пользователя
    /// </summary>
    public class AppUserTag
    {
        /// <summary>
        /// Id пользователя
        /// </summary>
        public int AppUserId { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public AppUser AppUser { get; set; }

        /// <summary>
        /// Id тега
        /// </summary>
        public int TagId { get; set; }

        /// <summary>
        /// Тег
        /// </summary>
        public Tag Tag { get; set; }
    }
}
