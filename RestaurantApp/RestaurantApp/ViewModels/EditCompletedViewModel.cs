using RestaurantApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace RestaurantApp.ViewModels
{
    public class EditCompletedViewModel
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public string Status { get; set; }
    }

}
