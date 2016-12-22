using LunchApp.Core;

namespace LunchApp.Models.ApplicationModels
{
    public class LocationModel : EntityBase
    {
        public string Address { get; set; }

        public int RestaurantId { get; set; }
        public RestaurantModel Restaurant { get; set; }
    }
}