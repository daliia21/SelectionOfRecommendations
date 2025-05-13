using TouristRoutes.Models;

namespace TouristRoutes.Services
{
    /// <summary>
    /// Сервис для создания списка рекомендаций
    /// </summary>
    public class RecomendationListService
    {
        private RoutesRepository _routeRepository;
        private AccountService _accountService;

        /// <summary>
        /// Конструктор сервиса
        /// </summary>
        public RecomendationListService()
        {
            _routeRepository = new RoutesRepository();
            _accountService = new AccountService();
        }

        public List<Route> SortedRoutesByTagCount()
        {            
            var routeList = _routeRepository.GetAllRoutesWithTags();
            var currentUserTags = _accountService.GetAllCurrentUserTags();
            var userTagIds = new HashSet<int>(currentUserTags.Select(t => t.Id));

            var sortedRoutes = routeList
                .OrderByDescending(route =>
                    route.RouteTags.Count(rt => userTagIds.Contains(rt.TagId)))
                .ToList();

            return sortedRoutes;

        }


    }
}
