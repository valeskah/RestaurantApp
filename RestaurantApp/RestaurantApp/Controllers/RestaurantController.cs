using Microsoft.AspNetCore.Mvc;
using RestaurantApp.Models;
using System.Collections.Generic;
using RestaurantApp.ViewModels;
using RestaurantApp.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantApp.Controllers
{
    public class RestaurantController : Controller
    {
        private RestaurantDbContext context;

        public RestaurantController(RestaurantDbContext dbContext)
        {
            context = dbContext;
        }

        
        // GET: /<controller>/
        public IActionResult Index()
        {

            List<Restaurant> restaurants = context.Restaurants.ToList();

            return View(restaurants);
        }

        public IActionResult Add()
        {
            AddRestaurantViewModel addRestaurantViewModel = new AddRestaurantViewModel(context.Categories.ToList());
            return View(addRestaurantViewModel);
        }


        [HttpPost]
        public IActionResult Add(AddRestaurantViewModel addRestaurantViewModel) 
        {
            RestaurantCategory newRestaurantCategory = context.Categories.Single(c => c.ID == addRestaurantViewModel.CategoryID);

            if (ModelState.IsValid)
            {
               
                Restaurant newRestaurant = new Restaurant
                {
                    Name = addRestaurantViewModel.Name,
                    Notes = addRestaurantViewModel.Notes,
                    Category = newRestaurantCategory
                };


                context.Restaurants.Add(newRestaurant);
                context.SaveChanges();

                return Redirect("/Restaurant");
            }

            return View(addRestaurantViewModel);

            
        }

        public IActionResult Remove()
        {
            ViewBag.title = "Remove Restaurants";
            ViewBag.restaurants = context.Restaurants.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Remove(int[] restaurantIds)
        {
            foreach (int restaurantId in restaurantIds)
            {
                Restaurant theRestaurant = context.Restaurants.Single(c => c.ID == restaurantId);
                context.Restaurants.Remove(theRestaurant);
                
            }

            context.SaveChanges();
            return Redirect("/");
        }
    }
}
