using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleRestaurantsProject0.DataModels;

namespace ConsoleRestaurantsProject0.Lib
{
    public class HelperLibrary
    {
        public static IEnumerable<Restaurant> SortRestaurantsByName(IEnumerable<Restaurant> restaurants)
        {
            return restaurants.OrderBy(r => r.Name);
        }

        public static IEnumerable<Restaurant> SearchRestaurantsByName(IEnumerable<Restaurant> restaurants,
            string searchValue)
        {
            return restaurants.Where(r => r.Name.Contains(searchValue));
        }
    }
}
