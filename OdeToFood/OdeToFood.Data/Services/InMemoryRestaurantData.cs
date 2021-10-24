using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {

        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>() {
                new Restaurant { Id=1,Name="Lance's Pizza", Cuisine = CuisineType.Italian},
                new Restaurant { Id=1,Name="franch rest", Cuisine = CuisineType.Franch},
                new Restaurant { Id=1,Name="Mago Grove", Cuisine = CuisineType.Indian}
            };
        }

                    
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
