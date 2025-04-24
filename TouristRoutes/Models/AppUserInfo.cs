using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristRoutes.Models
{
    /// <summary>
    /// Модель для хранения данных при заполнении анкеты
    /// <summary>
    public class AppUserInfo
    {
        /// <summary>
        /// Id анкеты пользователя
        /// <summary>       
        public int Id { get; set; }

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        

        /// <summary>
        /// Возраст пользователя
        /// <summary>       
        public string AgeCategory { get; set; }

        /// <summary>
        /// Предпочтительный вид туризма
        /// <summary>       
        public string TypeOfTourism { get; set; }

        /// <summary>
        /// Бюджет пользователя
        /// <summary>       
        public string Budget { get; set; }

        /// <summary>
        /// Предпочтительная длительность поездки
        /// <summary>       
        public string DurationOfTheTrip { get; set; }

        /// <summary>
        /// Частая локация пользователя
        /// <summary>       
        public string FrequentLocation { get; set; }

        /// <summary>
        /// Предпочтительный сезон
        /// <summary>       
        public string Season { get; set; }

        /// <summary>
        /// Уровень подготовки пользователя
        /// <summary>       
        public string LevelOfTraining { get; set; }

        
    }
}
