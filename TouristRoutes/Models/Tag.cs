
using TouristRoutes.Enums;

namespace TouristRoutes.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string TagName { get; set; }
        public TagType TagType { get; set; }
    }
}
