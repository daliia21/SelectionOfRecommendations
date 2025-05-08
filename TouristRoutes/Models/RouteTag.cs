

namespace TouristRoutes.Models
{
    public class RouteTag
    {
        public int RouteId { get; set; }
        public Route Route { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
