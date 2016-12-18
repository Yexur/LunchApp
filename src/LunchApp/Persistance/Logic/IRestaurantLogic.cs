using LunchApp.Models.ApplicationModels;
using LunchApp.Models.ApplicationViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LunchApp.Persistance.Logic
{
    public interface IRestaurantLogic
    {
        RestaurantModel FindById(int id);
        Task<List<RestaurantViewModel>> GetList();
        Task Save(RestaurantModel restaurant);
        void Delete(int id);
    }
}
