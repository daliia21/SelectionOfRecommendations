using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristRoutes.Models;

namespace TouristRoutes
{
    public static class AppState
    {
        public static bool IsAuthenticated { get; set; } = false;
        public static AppUser? CurrentAppUser { get; set; } = null;
    }
}
