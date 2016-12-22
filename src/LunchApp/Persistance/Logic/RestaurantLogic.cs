using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LunchApp.Models.ApplicationModels;
using LunchApp.Persistance.Repository;
using LunchApp.Models.ApplicationViewModels;
using System;

namespace LunchApp.Persistance.Logic
{
    public class RestaurantLogic : IRestaurantLogic
    {
        private readonly IRestaurantRepository _restaurantRepository;

        public RestaurantLogic(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }

        public void Delete(int id)
        {
            _restaurantRepository.Delete(id);
        }

        public RestaurantModel FindById(int id)
        {
           return _restaurantRepository.FindById(id);
        }

        public async Task<List<RestaurantViewModel>> GetList()
        {
            var restaurants = await _restaurantRepository.All();

            if (restaurants == null || !restaurants.Any()) 
            {
                return Enumerable.Empty<RestaurantViewModel>().ToList();
            }
            return MapRestaurantToViewModel(restaurants);
        }

        public async Task Save(RestaurantModel restaurant)
        {
            await _restaurantRepository.Insert(restaurant);
        }

        private List<RestaurantViewModel> MapRestaurantToViewModel(List<RestaurantModel> restaurants)
        {
            var restaurantList = restaurants.Select(x => new RestaurantViewModel()
            {
                RestaurantId = x.Id,
                Name = x.Name,
                FoodType = x.RestaurantType.FoodType,
                Locations = x.Locations
            });

            return restaurantList.ToList();
        }
    }
}
