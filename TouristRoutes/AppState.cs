
using TouristRoutes.Models;

namespace TouristRoutes
{
    public static class AppState
    {
        public static bool IsAuthenticated { get; set; } = false;
        public static AppUser? CurrentAppUser { get; set; } = null;
    }
}
