using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LunchApp.Models.ApplicationModels;
using LunchApp.Data;
using Microsoft.EntityFrameworkCore;

namespace LunchApp.Persistance.Repository
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private LunchAppDbContext _context;

        public RestaurantRepository(LunchAppDbContext context)
        {
            _context = context;
        }
        public async Task<List<RestaurantModel>> All()
        {
            return await _context.Restaurant
                .Include(f => f.RestaurantType).ToListAsync();
        }

        public void Delete(int id)
        {
            var entityToDelete = FindById(id);
            if (entityToDelete != null) {
                _context.Remove(entityToDelete);
            }
        }

        public RestaurantModel FindById(int id)
        {
            return _context.Restaurant
                .Include(f => f.RestaurantType)
                .SingleOrDefault(m => m.Id == id);
        }

        public async Task Insert(RestaurantModel restaurant)
        {
            if (restaurant.Id > 0) {
                _context.Update(restaurant);
            }
            else {
                _context.Add(restaurant);
            }
            await _context.SaveChangesAsync();
        }
    }
}
