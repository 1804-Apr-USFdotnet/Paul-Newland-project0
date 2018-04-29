using System;
using System.Collections.Generic;
using ConsoleRestaurantsProject0.DataModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Project0Test
{
    [TestClass]
    public class Project0HelperLibraryTests
    {
        private List<Restaurant> _restaurants = new List<Restaurant>()
        {
            new Restaurant(){Name = "B Restaurant 1", Id = 1},
            new Restaurant(){Name = "E Restaurant 2", Id = 2},
            new Restaurant(){Name = "A Restaurant 3", Id = 3},
            new Restaurant(){Name = "D Restaurant 4", Id = 4},
            new Restaurant(){Name = "C Restaurant 5 Special", Id = 5}
        };

        [TestMethod]
        public void SortRestaurantsByNameReturnsCorrectlyOrderedRestaurants()
        {
            
        }
    }
}
