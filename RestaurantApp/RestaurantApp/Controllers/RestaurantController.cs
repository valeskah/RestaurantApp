using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestaurantApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantApp.Controllers
{
    public class RestaurantController : Controller
    {
        
        // GET: /<controller>/
        public IActionResult Index()
        {

            ViewBag.restaurants = RestaurantData.GetAll();

            return View();
        }

        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        [Route("/Restaurant/Add")]
        public IActionResult NewRestaurant(Restaurant newRestaurant) //correspond with name values in form -- name values have to match properties of class
        {

            //Add new restaurant to restaurant list
            RestaurantData.Add(newRestaurant);
            
            return Redirect("/Restaurant");
        }

        public IActionResult Remove()
        {
            ViewBag.title = "Remove Restaurants";
            ViewBag.restaurants = RestaurantData.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Remove(int[] restaurantIds)
        {
            foreach (int restaurantId in restaurantIds)
            {
                RestaurantData.Remove(restaurantId);
            }
            
            return Redirect("/");
        }
    }
}
