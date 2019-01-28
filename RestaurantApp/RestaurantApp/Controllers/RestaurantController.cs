using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantApp.Controllers
{
    public class RestaurantController : Controller
    {
        static private Dictionary<string, string> Restaurants = new Dictionary<string, string>();

        // GET: /<controller>/
        public IActionResult Index()
        {

            ViewBag.restaurants = Restaurants;

            return View();
        }

        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        [Route("Restaurant/Add")]
        public IActionResult NewRestaurant(string name, string notes = "")
        {
            //Add new restaurant to restaurant list
            Restaurants.Add(name, notes);

            return Redirect("/Restaurant");
        }
    }
}
