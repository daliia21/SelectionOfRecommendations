using Microsoft.EntityFrameworkCore;
using TouristRoutes.Models;

namespace TouristRoutes.Services
{
    /// <summary>
    /// Сервис для управления маршрутами
    /// </summary>
    public class RoutesRepository
    {
        private AppDbContext _dbContext;

        /// <summary>
        /// Конструктор сервиса
        /// </summary>
        public RoutesRepository()
        {
            _dbContext = new AppDbContext();
        }

        /// <summary>
        /// Метод для добавления нового маршрута
        /// </summary>
        public void AddNewRoute(Route route)
        {
            _dbContext.Routes.Add(route);
            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Метод для получения маршрута по ID
        /// </summary>
        public Route GetRouteById(int Id)
        {
            var route = _dbContext.Routes
                .Where(r => r.Id == Id)
                .FirstOrDefault();
            return route;
        }

        /// <summary>
        /// Метод для получения маршрута с тегами
        /// </summary>
        public Route GetRouteWithTags(int Id)
        {
            var route = _dbContext.Routes
                .Include(route => route.RouteTags)
                .Where(r => r.Id == Id)
                .FirstOrDefault();
                           
            return route;
        }

        /// <summary>
        /// Метод для получения всех маршрутов
        /// </summary>
        public List<Route> GetAllRoutes()
        {
            return _dbContext.Routes.ToList();
        }

        /// <summary>
        /// Метод для получения всех маршрутов с тегами 
        /// </summary>
        public List<Route> GetAllRoutesWithTags()
        {
            var routes = _dbContext.Routes
                .Include(route => route.RouteTags)
                .ToList();
            return routes;
        }

        /// <summary>
        /// Метод для обновления маршрута
        /// </summary>
        public bool UpdateRoute(int Id, Route newRoute)
        {
            var route = _dbContext.Routes
                .Include(route => route.RouteTags)
                .Where(r => r.Id == Id)
                .FirstOrDefault();

            if (route == null)
            {
                return false;
            }
            
            route.RoutePrice = newRoute.RoutePrice;
            route.RouteLocation = newRoute.RouteLocation;
            route.RouteDescription = newRoute.RouteDescription;
            route.RouteDuration = newRoute.RouteDuration;
            route.RouteImagePath = newRoute.RouteImagePath;
            
            _dbContext.SaveChanges();

            return true;
        }

        /// <summary>
        /// Метод для добавления тегов к маршруту
        /// </summary>
        public void AddTagsToRoute(int Id, List<Tag> tags)
        {
            var route = _dbContext.Routes
                .Include(route => route.RouteTags)
                .Where(r => r.Id == Id)
                .FirstOrDefault();

            foreach (var tag in tags)
            {
                var routeTag = new RouteTag
                {
                    RouteId = route.Id,
                    TagId = tag.Id,
                    Route = route,
                    Tag = tag

                };

                bool isAlreadyLinked = route.RouteTags
                    .Any(rt => rt.RouteId == route.Id && rt.TagId == tag.Id);

                if (!isAlreadyLinked)
                {
                    route.RouteTags.Add(routeTag);
                }
                
            }
            _dbContext.SaveChanges();
        }

    }
}
