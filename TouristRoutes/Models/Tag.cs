using TouristRoutes.Enums;

namespace TouristRoutes.Models
{
    /// <summary>
    /// Модель для хранения информации о теге
    /// </summary>
    public class Tag
    {
        /// <summary>
        /// Id тега
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название тега
        /// </summary>
        public string TagName { get; set; }

        /// <summary>
        /// Тип тега
        /// </summary>
        public TagType TagType { get; set; }
    }
}
