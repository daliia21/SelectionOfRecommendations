

using TouristRoutes.Dtos;
using TouristRoutes.Models;

namespace TouristRoutes.Services
{
    public class RoutesRepositoryService
    {
        private AppDbContext _dbContext;
        public RoutesRepositoryService()
        {
            _dbContext = new AppDbContext();
        }

        public void AddNewRoute(Route route)
        {
            _dbContext.Routes.Add(route);
        }

        public Route GetRouteById(int id)
        {
            var route = _dbContext.Routes
                .Where(r => r.Id == id)
                .FirstOrDefault();
            return route;
        }
    }
}
