using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Models
{
    public class Restaurant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }

        public int CategoryID { get; set; } //foreign key
        public RestaurantCategory Category { get; set; } 
        
    }
}
