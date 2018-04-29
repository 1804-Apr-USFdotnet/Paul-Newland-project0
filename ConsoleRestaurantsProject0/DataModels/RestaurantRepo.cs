using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRestaurantsProject0.DataModels
{
    public class RestaurantRepo
    {
        private readonly ApplicationDbContext _context;

        public RestaurantRepo()
        {
            _context = new ApplicationDbContext();
        }

        public List<Restaurant> GetRestaurants()
        {
            return _context.Restaurants.Include(r => r.Address).ToList();
        }

        public Restaurant GetRestaurant(int id)
        {
            return _context.Restaurants.SingleOrDefault(r => r.Id == id);
        }

        public void CreateRestaurant(string name, string street, string city, string state, string zip)
        {
            var restaurant = new Restaurant()
            {
                Name = name,
                Address = new Address()
                {
                    Street = street,
                    City = city,
                    State = state,
                    Zip = zip
                }
            };

            _context.Restaurants.Add(restaurant);
            _context.SaveChanges();
        }

        public void UpdateRestaurant(string name, string newName)
        {
            var restaurant = GetRestaurantByName(name);
            if (restaurant == null) return;
            restaurant.Name = newName;
            _context.SaveChanges();
        }

        public void DeleteRestaurant(string name)
        {
            var restaurant = GetRestaurantByName(name);
            if (restaurant == null) return;
            _context.Restaurants.Remove(restaurant);
            _context.SaveChanges();
        }

        public Restaurant GetRestaurantByName(string name)
        {
            return _context.Restaurants.SingleOrDefault(r => r.Name == name);
        }

        public double GetAverageRating(int restaurantId)
        {
            var restaurant = _context.Restaurants.Find(restaurantId);
            var reviews = _context.Reviews.Where(r => r.RestaurantId == restaurant.Id);
            return reviews.Average(r => r.Rating);
        }

        public Restaurant GetTopRatedRestaurant()
        {
            var restaurants = _context.Restaurants.Include(r => r.Reviews);
            return restaurants.Aggregate((r1, r2) => GetRating(r1) > GetRating(r2) ? r1 : r2);
        }

        private static double GetRating(Restaurant restaurant) => restaurant.Reviews.Average(r => r.Rating);
    }
}
