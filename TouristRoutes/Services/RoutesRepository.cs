

using Microsoft.EntityFrameworkCore;
using TouristRoutes.Dtos;
using TouristRoutes.Models;

namespace TouristRoutes.Services
{
    public class RoutesRepository
    {
        private AppDbContext _dbContext;
        public RoutesRepository()
        {
            _dbContext = new AppDbContext();
        }

        public void AddNewRoute(Route route)
        {
            _dbContext.Routes.Add(route);
            _dbContext.SaveChanges();
        }

        public Route GetRouteById(int Id)
        {
            var route = _dbContext.Routes
                .Where(r => r.Id == Id)
                .FirstOrDefault();
            return route;
        }

        public Route GetRouteWithTags(int Id)
        {
            var route = _dbContext.Routes
                .Include(route => route.RouteTags)
                .Where(r => r.Id == Id)
                .FirstOrDefault();
                           
            return route;
        }

        public List<Route> GetAllRoutes()
        {
            return _dbContext.Routes.ToList();
        }

        public List<Route> GetAllRoutesWithTags()
        {
            var routes = _dbContext.Routes
                .Include(route => route.RouteTags)
                .ToList();
            return routes;
        }

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

        public void AddTagsToRoute(int Id, List<Tag> tags)
        {
            var route = _dbContext.Routes
                .Include(route => route.RouteTags)
                .Where(r => r.Id == Id)
                .FirstOrDefault();

            foreach (var tag in tags)
            {
                RouteTag routeTag = new RouteTag
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
