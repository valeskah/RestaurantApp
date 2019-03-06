using RestaurantApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.ViewModels
{
    public class EditRestaurantViewModel
    {
        public string Name { get; set; }

        public int ID { get; set; }

        [Display(Name = "Category")]
        public int CategoryID { get; set; }

        public string Notes { get; set; }

        public List<SelectListItem> Categories { get; set; }

        public EditRestaurantViewModel()
        {

        }

        public EditRestaurantViewModel(IEnumerable<RestaurantCategory> categories)
        {

            Categories = new List<SelectListItem>();

            foreach (RestaurantCategory category in categories)
            {
                Categories.Add(new SelectListItem
                {
                    Value = category.ID.ToString(),
                    Text = category.Name,
                });
            }
        }

    }
}