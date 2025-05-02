using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristRoutes.Models
{
    public class AppUserTag
    {
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
