namespace TouristRoutes.Models
{
    /// <summary>
    /// Модель для храения информации о теге маршрута
    /// </summary>
    public class RouteTag
    {
        /// <summary>
        /// Id маршрута
        /// </summary>
        public int RouteId { get; set; }

        /// <summary>
        /// Маршрут
        /// </summary>
        public Route Route { get; set; }

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
