using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestaurantApp.Models;
using RestaurantApp.Data;
using RestaurantApp.ViewModels;

namespace RestaurantApp.Controllers
{
    public class CategoryController : Controller
    {
        

        public IActionResult Index()
        {
            List<RestaurantCategory> categories = context.Categories.ToList();
            return View(categories);
        }

        private readonly RestaurantDbContext context;

        public CategoryController(RestaurantDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Add()
        {
            AddCategoryViewModel addCategoryViewModel = new AddCategoryViewModel();
            return View(addCategoryViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddCategoryViewModel addCategoryViewModel)
        {
            if (ModelState.IsValid)
            {
                RestaurantCategory newCategory = new RestaurantCategory
                {
                    Name = addCategoryViewModel.Name
                };

                context.Categories.Add(newCategory);
                context.SaveChanges();

                return Redirect("/Category");
            }

            return View(addCategoryViewModel);
        }


        public IActionResult Remove()
        {
            ViewBag.title = "Remove Categories";
            ViewBag.categories = context.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Remove(int[] categoryIds)
        {
            foreach (int categoryId in categoryIds)
            {
                RestaurantCategory theCategory = context.Categories.Single(c => c.ID == categoryId);
                context.Categories.Remove(theCategory);

            }

            context.SaveChanges();
            return Redirect("/category");
        }
    }
}