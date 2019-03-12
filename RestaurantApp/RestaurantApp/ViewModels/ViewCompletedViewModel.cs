using RestaurantApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.ViewModels
{
    public class ViewCompletedViewModel
    {
        public string Name { get; set; }

        public Status.CompletionStatus Status { get; set; }

        public string Rating { get; set; }

        public int ID { get; set; }

        public string Notes { get; set; }
    }
}
