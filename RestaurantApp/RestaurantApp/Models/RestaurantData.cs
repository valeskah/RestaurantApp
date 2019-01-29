using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Models
{
    public class RestaurantData
    {
        static private List<Restaurant> restaurants = new List<Restaurant>();

        // GetAll
        public static List<Restaurant> GetAll()
        {
            return restaurants;
        }
  
        // Add
        public static void Add(Restaurant newRestaurant)
        {
            restaurants.Add(newRestaurant);
        }

        // Remove
        public static void Remove(int id)
        {
            Restaurant restaurantToRemove = GetById(id);
            restaurants.Remove(restaurantToRemove);
        }

        // GetById
        public static Restaurant GetById(int id)
        {
            return restaurants.Single(x => x.RestaurantId == id);
        }
    }
}
