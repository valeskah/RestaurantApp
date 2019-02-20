using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Models
{
    public class RestaurantCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public IList<Restaurant> Restaurants { get; set; }
    }
}
