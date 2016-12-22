using LunchApp.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LunchApp.Models.ApplicationModels
{
    public class RestaurantTypeModel : EntityBase
    {
        [Display(Name = "Type of Food")]
        public string FoodType { get; set; }

        public List<RestaurantModel> Restaurants { get; set; }
    }
}