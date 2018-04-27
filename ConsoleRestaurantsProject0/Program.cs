using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleRestaurantsProject0.DataModels;

namespace ConsoleRestaurantsProject0
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new RestaurantRepo();
            var restaurants = r.GetRestaurants();
            Console.WriteLine(restaurants.Count());
        }
    }
}
