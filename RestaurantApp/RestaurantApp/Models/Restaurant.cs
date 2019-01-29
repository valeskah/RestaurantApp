using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Models
{
    public class Restaurant
    {
        public string Name { get; set; }
        public string Notes { get; set; }
        public int RestaurantId { get; set; }
        private static int nextId = 1;

        public Restaurant()
        {
            RestaurantId = nextId;
            nextId++;
        }
    }
}
