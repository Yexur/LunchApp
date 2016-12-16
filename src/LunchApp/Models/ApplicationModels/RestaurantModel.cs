using LunchApp.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LunchApp.Models.ApplicationModels
{
    public class RestaurantModel : EntityBase
    {
        [Display(Name = "Restaurant")]
        public string Name { get; set; }

        public int RestaurantTypeId { get; set; }
        
        public RestaurantTypeModel RestaurantType { get; set; }

        public List<LocationModel> Locations { get; set; }
    }
}
