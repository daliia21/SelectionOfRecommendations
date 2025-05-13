using TouristRoutes.Models;

namespace TouristRoutes.Services
{
    /// <summary>
    /// Сервис для создания списка рекомендаций
    /// </summary>
    public class ReconendationListService
    {
        private RoutesRepository _routeRepository;

        /// <summary>
        /// Конструктор сервиса
        /// </summary>
        public ReconendationListService()
        {
            _routeRepository = new RoutesRepository();
        }

        public List<Route> SortedRoutesByTagCount()
        {
            var routeList = _routeRepository.GetAllRoutesWithTags();

        }


    }
}
