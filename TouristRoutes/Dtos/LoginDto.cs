namespace TouristRoutes.Dtos
{
    /// <summary>
    /// DTO для входа
    /// </summary>
    public class LoginDto
    {
        /// <summary>
        /// Email пользователя
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Пароль пользователя
        /// </summary>
        public string Password { get; set; }
    }
}
