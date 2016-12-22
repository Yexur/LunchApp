using LunchApp.Models.ApplicationModels;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LunchApp.Models.ApplicationViewModels
{
    public class RestaurantViewModel
    {
        public int RestaurantId { get; set; }

        [Display(Name = "Restaurant")]
        public string Name { get; set; }

        [Display(Name = "Type of Food")]
        public string FoodType { get; set; }

        public List<LocationModel> Locations { get; set; }
    }
}
