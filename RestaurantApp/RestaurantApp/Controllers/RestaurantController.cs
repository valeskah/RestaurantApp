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
            List<Restaurant> restaurants = context.Restaurants.Include(c => c.Category).ToList();
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
                    Category = newRestaurantCategory,
                    RestaurantStatus = addRestaurantViewModel.RestaurantStatus

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

        public IActionResult Edit()
        {
            List<Restaurant> restaurants = context.Restaurants.Include(c => c.Category).ToList();
            return View(restaurants);
        }

        public IActionResult EditRestaurant(int ID)
        {
            Restaurant restaurantToEdit = context.Restaurants.First(c => c.ID == ID);
            EditRestaurantViewModel editRestaurantViewModel = new EditRestaurantViewModel(context.Categories.ToList())
            {
                Name = restaurantToEdit.Name,
                CategoryID = restaurantToEdit.CategoryID,
                Notes = restaurantToEdit.Notes,
                ID = restaurantToEdit.ID
            };
            return View(editRestaurantViewModel);
        }

        [HttpPost]
        public IActionResult EditRestaurant(EditRestaurantViewModel editRestaurantViewModel)
        {
            int ID = editRestaurantViewModel.ID;
            Restaurant updatedRestaurant = context.Restaurants.First(c => c.ID == ID);

            updatedRestaurant.Name = editRestaurantViewModel.Name;
            updatedRestaurant.CategoryID = editRestaurantViewModel.CategoryID;
            updatedRestaurant.Notes = editRestaurantViewModel.Notes;

            context.Restaurants.Update(updatedRestaurant);
            context.SaveChanges();

            return Redirect("/Restaurant");

        }

        [HttpPost]
        public IActionResult Complete(int ID)
        {
            Restaurant restaurantToComplete = context.Restaurants.First(c => c.ID == ID);

            RateRestaurantViewModel rateRestaurantViewModel = new RateRestaurantViewModel();

            rateRestaurantViewModel.Name = restaurantToComplete.Name;
            rateRestaurantViewModel.Notes = restaurantToComplete.Notes;
            rateRestaurantViewModel.ID = restaurantToComplete.ID;

            return View(rateRestaurantViewModel);
        }

        public IActionResult RateRestaurant(RateRestaurantViewModel rateRestaurantViewModel)
        {
            int ID = rateRestaurantViewModel.ID;
            Restaurant ratedRestaurant = context.Restaurants.First(C => C.ID == ID);

            ratedRestaurant.Rating = rateRestaurantViewModel.Rating;
            ratedRestaurant.Notes = rateRestaurantViewModel.Notes;
            ratedRestaurant.RestaurantStatus = Status.CompletionStatus.Complete;

            context.Restaurants.Update(ratedRestaurant); ;

            context.Restaurants.Update(ratedRestaurant);
            context.SaveChanges();

            return Redirect("/Restaurant");
        }

        public IActionResult ViewRestaurant(int ID)
        {
            Restaurant restaurantToView = context.Restaurants.First(c => c.ID == ID);
            int CategoryID = restaurantToView.CategoryID;
            RestaurantCategory CategoryName = context.Categories.First(c => c.ID == CategoryID);
            string Category = CategoryName.Name;

            ViewRestaurantViewModel viewRestaurantViewModel = new ViewRestaurantViewModel()
            {
                Name = restaurantToView.Name,
                ID = restaurantToView.ID,
                Category = Category,
                Notes = restaurantToView.Notes
            };

            return View(viewRestaurantViewModel);
        }

        public IActionResult ViewCompleted()
        {
            List<Restaurant> restaurants = context.Restaurants.Include(c => c.Category).ToList();
            return View(restaurants);
        }

        public IActionResult ViewCompletedRestaurant(int ID)
        {
            Restaurant restaurantToView = context.Restaurants.First(c => c.ID == ID);
            ViewCompletedViewModel viewCompletedViewModel = new ViewCompletedViewModel()
            {
                Name = restaurantToView.Name,
                Status = restaurantToView.RestaurantStatus,
                Rating = restaurantToView.Rating,
                ID = restaurantToView.ID,
                Notes = restaurantToView.Notes
            };

            return View(viewCompletedViewModel);

        }



        public IActionResult EditCompleted(int ID)
        {
            Restaurant completedToEdit = context.Restaurants.First(c => c.ID == ID);
            EditCompletedViewModel editCompletedViewModel = new EditCompletedViewModel()
            {
                Name = completedToEdit.Name,
                ID = completedToEdit.ID
            };

            return View(editCompletedViewModel);
        }

        [HttpPost]
        public IActionResult EditCompleted(EditCompletedViewModel editCompletedViewModel)
        {
            int ID = editCompletedViewModel.ID;
            Restaurant updatedRestaurant = context.Restaurants.First(c => c.ID == ID);

            if (editCompletedViewModel.Status == "Complete")
            {
                updatedRestaurant.RestaurantStatus = Status.CompletionStatus.Complete;
            }

            else
            {
                updatedRestaurant.RestaurantStatus = Status.CompletionStatus.Incomplete;
            }

            context.Restaurants.Update(updatedRestaurant);
            context.SaveChanges();

            return Redirect("/Restaurant");
        }

        public IActionResult EditRating(int ID)
        {
            Restaurant ratingToEdit = context.Restaurants.First(c => c.ID == ID);
            EditRatingViewModel editRatingViewModel = new EditRatingViewModel()
            {
                Name = ratingToEdit.Name,
                ID = ratingToEdit.ID,
                Notes = ratingToEdit.Notes
            };

            return View(editRatingViewModel);
        }

        [HttpPost]
        public IActionResult EditRating(EditRatingViewModel editRatingViewModel)
        {
            int ID = editRatingViewModel.ID;
            Restaurant updatedRating = context.Restaurants.First(c => c.ID == ID);

            updatedRating.Notes = editRatingViewModel.Notes;
            updatedRating.Rating = editRatingViewModel.Rating;

            context.Restaurants.Update(updatedRating);
            context.SaveChanges();

            return Redirect("/Restaurant");
        }


        public IActionResult FilterBy()
        {
            List<RestaurantCategory> categories = context.Categories.ToList();
            categories = categories.OrderBy(n => n.Name).ToList();
            return View(categories);
        }
        
        [HttpPost]
        public IActionResult FilterByCategory(string[] categoryNames)
        {
            List<Restaurant> restaurants = context.Restaurants.Include(c => c.Category).ToList();
            List<Restaurant> filteredRestaurants = new List<Restaurant>();

            foreach(string category in categoryNames)
            {
                foreach(Restaurant restaurant in restaurants)
                {
                    if (restaurant.RestaurantStatus == Status.CompletionStatus.Incomplete)
                    {
                        string restaurantCategory = restaurant.Category.Name.ToString();

                        if (category == restaurantCategory)
                        {
                            filteredRestaurants.Add(restaurant);
                        }
                    }
                }

            }

            return View(filteredRestaurants);
        }
    }  
}
