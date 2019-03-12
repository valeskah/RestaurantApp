using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.ViewModels
{
    public class EditRatingViewModel
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Notes { get; set; }
        public string Rating { get; set; }
    }
}
