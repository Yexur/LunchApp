using LunchApp.Models.ApplicationModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LunchApp.Persistance.Repository
{
    public interface IRestaurantRepository
    {
        Task<List<RestaurantModel>> All();
        Task Insert(RestaurantModel restaurant);
        void Delete(int id);
        RestaurantModel FindById(int id);
    }
}
