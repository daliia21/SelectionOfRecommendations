using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristRoutes.Models
{
    /// <summary>
    /// Модель для хранения избранных маршрутов у пользователей
    /// </summary>
    public class UserFavoriteRoute
    {
        /// <summary>
        /// Id пользователя
        /// </summary>
        public int AppUserId { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public AppUser AppUser { get; set; }

        /// <summary>
        /// Id маршрута
        /// </summary>
        public int RouteId { get; set; }

        /// <summary>
        /// Маршрут
        /// </summary>
        public Route Route { get; set; }
    }
}
