using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LunchApp.Models.ApplicationModels;
using LunchApp.Persistance.Repository;

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

        public async Task<List<RestaurantModel>> GetList()
        {
            var restaurants = await _restaurantRepository.All();

            if (restaurants == null || !restaurants.Any()) 
            {
                return Enumerable.Empty<RestaurantModel>().ToList();
            }
            return restaurants;
        }

        public async Task Save(RestaurantModel restaurant)
        {
            await _restaurantRepository.Insert(restaurant);
        }
    }
}
