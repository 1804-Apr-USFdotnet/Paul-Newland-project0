using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleRestaurantsProject0.DataModels;
using ConsoleRestaurantsProject0.Lib;

namespace ConsoleRestaurantsProject0
{
    class Program
    {
        static void Main(string[] args)
        {
            var restaurantRepo = new RestaurantRepo();
            var restaurants = restaurantRepo.GetRestaurants();
            var input = "";
            while (input.ToLower() != "end")
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Enter 'restaurants' to see Restaurants");
                Console.WriteLine("Enter 'end' to end program");

                input = Console.ReadLine();

                if (String.IsNullOrEmpty(input))
                    input = "";

                if (input.ToLower() == "restaurants")
                {
                    foreach (var r in restaurants)
                    {
                        Console.WriteLine(r);
                    }
                }
            }

            // HelperLibrary.SortRestaurantsByName(restaurants)
        }
    }
}
