using System;
using System.Collections.Generic;
using ConsoleRestaurantsProject0.DataModels;
using ConsoleRestaurantsProject0.Lib;
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

        private List<Restaurant> _restaurantsSorted = new List<Restaurant>()
        {
            new Restaurant(){Name = "A Restaurant 3", Id = 3},
            new Restaurant(){Name = "B Restaurant 1", Id = 1},
            new Restaurant(){Name = "C Restaurant 5 Special", Id = 5},
            new Restaurant(){Name = "D Restaurant 4", Id = 4},
            new Restaurant(){Name = "E Restaurant 2", Id = 2}
        };

        [TestMethod]
        public void SortRestaurantsByNameReturnsCorrectlyOrderedRestaurants0()
        {
            var list = HelperLibrary.SortRestaurantsByName(_restaurants);
            Assert.AreEqual(list[0].Id, _restaurantsSorted[0].Id);
        }

        [TestMethod]
        public void SortRestaurantsByNameReturnsCorrectlyOrderedRestaurants1()
        {
            var list = HelperLibrary.SortRestaurantsByName(_restaurants);
            Assert.AreEqual(list[1].Id, _restaurantsSorted[1].Id);
        }

        [TestMethod]
        public void SortRestaurantsByNameReturnsCorrectlyOrderedRestaurants2()
        {
            var list = HelperLibrary.SortRestaurantsByName(_restaurants);
            Assert.AreEqual(list[2].Id, _restaurantsSorted[2].Id);
        }

        [TestMethod]
        public void SortRestaurantsByNameReturnsCorrectlyOrderedRestaurants3()
        {
            var list = HelperLibrary.SortRestaurantsByName(_restaurants);
            Assert.AreEqual(list[3].Id, _restaurantsSorted[3].Id);
        }

        [TestMethod]
        public void SortRestaurantsByNameReturnsCorrectlyOrderedRestaurants4()
        {
            var list = HelperLibrary.SortRestaurantsByName(_restaurants);
            Assert.AreEqual(list[4].Id, _restaurantsSorted[4].Id);
        }

        [TestMethod]
        public void SortRestaurantsByNameDoesNotReturnUnCorrectlyOrderedRestaurants0()
        {
            var list = HelperLibrary.SortRestaurantsByName(_restaurants);
            Assert.AreNotEqual(list[3].Id, _restaurantsSorted[4].Id);
        }

        [TestMethod]
        public void SortRestaurantsByNameDoesNotReturnUnCorrectlyOrderedRestaurants1()
        {
            var list = HelperLibrary.SortRestaurantsByName(_restaurants);
            Assert.AreNotEqual(list[4].Id, _restaurantsSorted[2].Id);
        }

        [TestMethod]
        public void SearchRestaurantsByNameReturnsCorrectRestaurants0()
        {
            var list = HelperLibrary.SearchRestaurantsByName(_restaurants, "3");
            Assert.AreEqual(list[0].Id, 3);
        }

        [TestMethod]
        public void SearchRestaurantsByNameReturnsCorrectRestaurants1()
        {
            var list = HelperLibrary.SearchRestaurantsByName(_restaurants, "Restaurant");
            Assert.AreEqual(list.Count, 5);
        }

        [TestMethod]
        public void SearchRestaurantsByNameDoesNotReturnUnCorrectRestaurants0()
        {
            var list = HelperLibrary.SearchRestaurantsByName(_restaurants, "3");
            Assert.AreNotEqual(list[0].Id, 2);
        }

        [TestMethod]
        public void SearchRestaurantsByNameDoesNotReturnUnCorrectRestaurants1()
        {
            var list = HelperLibrary.SearchRestaurantsByName(_restaurants, "Restaurant");
            Assert.AreNotEqual(list.Count, 4);
        }
    }
}
