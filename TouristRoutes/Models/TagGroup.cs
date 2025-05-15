using TouristRoutes.Enums;

namespace TouristRoutes.Models
{
    /// <summary>
    /// Промежуточная модель для сесериализации JSON файла с тегами
    /// </summary>
    public class TagGroup
    {
        /// <summary>
        /// Тип тега
        /// </summary>
        public TagType TagType { get; set; }

        /// <summary>
        /// Список тегов этого типа
        /// </summary>
        public List<string> TagName { get; set; }
    }
}
