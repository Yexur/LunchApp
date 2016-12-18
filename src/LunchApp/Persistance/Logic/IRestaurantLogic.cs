using LunchApp.Models.ApplicationModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LunchApp.Persistance.Logic
{
    public interface IRestaurantLogic
    {
        RestaurantModel FindById(int id);
        Task<List<RestaurantModel>> GetList();
        Task Save(RestaurantModel restaurant);
        void Delete(int id);
    }
}
