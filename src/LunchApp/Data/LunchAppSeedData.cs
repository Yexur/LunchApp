using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LunchApp.Models.ApplicationModels;

namespace LunchApp.Data
{
    public class LunchAppSeedData
    {
        private LunchAppDbContext _context;

        public LunchAppSeedData(LunchAppDbContext context)
        {
            _context = context;
        }

        public void EnsureSeedData() 
        {
            if (! _context.Restaurant.Any()) 
            {
                var fastFood = new RestaurantTypeModel()
                    {
                        Created = DateTime.Now,
                        Updated = DateTime.Now,
                        FoodType = "Fast Food",
                        Restaurants = new List<RestaurantModel>()
                    };

                var macdonalds = new RestaurantModel()
                    {
                        Created = DateTime.Now,
                        Updated = DateTime.Now,
                        Name = "MacDonalds",
                        Locations = new List<LocationModel>()
                    };

                var macdonaldsLocationA = new LocationModel()
                    {
                        Created = DateTime.Now,
                        Updated = DateTime.Now,
                        Address = "SomePlace Street 22"
                    };

                var macdonaldsLocationB = new LocationModel()
                    {
                        Created = DateTime.Now,
                        Updated = DateTime.Now,
                        Address = "Macdonald Street"
                    };

                var aAndW = new RestaurantModel()
                    {
                        Created = DateTime.Now,
                        Updated = DateTime.Now,
                        Name = "A and W",
                        Locations = new List<LocationModel>()
                    };

                var aAndWLocationA = new LocationModel()
                    {
                        Created = DateTime.Now,
                        Updated = DateTime.Now,
                        Address = "Burger Street"
                    };

                var aAndWLocationB = new LocationModel()
                    {
                        Created = DateTime.Now,
                        Updated = DateTime.Now,
                        Address = "Cholestral Way"
                    };

                macdonalds.Locations.Add(macdonaldsLocationA);
                macdonalds.Locations.Add(macdonaldsLocationB);
                aAndW.Locations.Add(aAndWLocationA);
                aAndW.Locations.Add(aAndWLocationB);
                fastFood.Restaurants.Add(macdonalds);
                fastFood.Restaurants.Add(aAndW);
                _context.RestaurantType.Add(fastFood);

                var sushi = new RestaurantTypeModel()
                    {
                        Created = DateTime.Now,
                        Updated = DateTime.Now,
                        FoodType = "Sushi",
                        Restaurants = new List<RestaurantModel>()
                    };

                var badSushi = new RestaurantModel()
                    {
                        Created = DateTime.Now,
                        Updated = DateTime.Now,
                        Name = "Bad Sushi",
                        Locations = new List<LocationModel>()
                    };

                var badSushiLocationA = new LocationModel()
                    {
                        Created = DateTime.Now,
                        Updated = DateTime.Now,
                        Address = "Food poisioning Street"
                    };

                var badSushiLocationB = new LocationModel()
                    {
                        Created = DateTime.Now,
                        Updated = DateTime.Now,
                        Address = "Hug The Bowl Way"
                    };

                var goodSushi = new RestaurantModel()
                    {
                        Created = DateTime.Now,
                        Updated = DateTime.Now,
                        Name = "Good Sushi",
                        Locations = new List<LocationModel>()
                    };

                var goodSushiLocationA = new LocationModel()
                    {
                        Created = DateTime.Now,
                        Updated = DateTime.Now,
                        Address = "Tempura Street"
                    };

                var goodSushiLocationB = new LocationModel()
                    {
                        Created = DateTime.Now,
                        Updated = DateTime.Now,
                        Address = "Yum Street"
                    };

                badSushi.Locations.Add(badSushiLocationA);
                badSushi.Locations.Add(badSushiLocationB);
                goodSushi.Locations.Add(goodSushiLocationA);
                goodSushi.Locations.Add(goodSushiLocationB);
                sushi.Restaurants.Add(badSushi);
                sushi.Restaurants.Add(goodSushi);
                _context.RestaurantType.Add(sushi);

                var breakfast = new RestaurantTypeModel()
                {
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                    FoodType = "Breakfast",
                    Restaurants = new List<RestaurantModel>()
                };

                var greasySpoon = new RestaurantModel()
                {
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                    Name = "Greasy Spoon",
                    Locations = new List<LocationModel>()
                };

                var greasySpoonLocationA = new LocationModel()
                {
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                    Address = "Hi-Fat"
                };

                var greasySpoonLocationB = new LocationModel()
                {
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                    Address = "Bacon Grease Street"
                };

                var healthyBreakfast = new RestaurantModel()
                {
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                    Name = "Good Sushi",
                    Locations = new List<LocationModel>()
                };

                var healthyBreakfastLocationA = new LocationModel()
                {
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                    Address = "TasteNoGood Street"
                };

                var healthyBreakfastLocationB = new LocationModel()
                {
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                    Address = "Granola Way"
                };

                greasySpoon.Locations.Add(greasySpoonLocationA);
                greasySpoon.Locations.Add(greasySpoonLocationB);
                healthyBreakfast.Locations.Add(healthyBreakfastLocationA);
                healthyBreakfast.Locations.Add(healthyBreakfastLocationB);
                breakfast.Restaurants.Add(greasySpoon);
                breakfast.Restaurants.Add(healthyBreakfast);
                _context.RestaurantType.Add(breakfast);

                _context.SaveChanges();
            }
        }
    }
}
