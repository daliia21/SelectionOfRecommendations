using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristRoutes.Dtos
{
    public class AnketaDto
    {
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

        /// <summary>
        /// Цель поездки
        /// <summary> 
        public string Purpose { get; set; }
    }
}
