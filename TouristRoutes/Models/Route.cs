
namespace TouristRoutes.Models
{
    public class Route
    {
        public int Id { get; set; }
        public string RouteName { get; set; }
        public decimal RoutePrice { get; set; }
        public string RouteLocation { get; set; }
        public string RouteDuration { get; set; }
        public string LevelOfTraining { get; set; }
        public string RouteDescription { get; set; }
        public string RouteImagePath { get; set; }
        public List<RouteTag> RouteTags { get; set; } = new List<RouteTag>();

    }
}
