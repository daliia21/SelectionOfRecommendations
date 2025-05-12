namespace TouristRoutes.Models
{
    /// <summary>
    /// Модель для хранения информации о маршруте
    /// </summary>
    public class Route
    {
        /// <summary>
        /// Id маршрута
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название маршрута
        /// </summary>
        public string RouteName { get; set; }

        /// <summary>
        /// Стоимость маршрута
        /// </summary>
        public string RoutePrice { get; set; }

        /// <summary>
        /// Расположение маршрута
        /// </summary>
        public string RouteLocation { get; set; }

        /// <summary>
        /// Длительность маршрута
        /// </summary>
        public string RouteDuration { get; set; }

        /// <summary>
        /// Уровень подготовки, необходимый для участия в маршруте
        /// </summary>
        public string LevelOfTraining { get; set; }

        /// <summary>
        /// Описание маршрута
        /// </summary>
        public string RouteDescription { get; set; }

        /// <summary>
        /// Ссылка на фотографию маршрута
        /// </summary>
        public string RouteImagePath { get; set; }

        /// <summary>
        /// Список тегов маршрута
        /// </summary>
        public List<RouteTag> RouteTags { get; set; } = new List<RouteTag>();

    }
}
