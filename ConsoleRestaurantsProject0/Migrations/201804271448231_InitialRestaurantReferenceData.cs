using System.Collections.Generic;

namespace ConsoleRestaurantsProject0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialRestaurantReferenceData : DbMigration
    {
        private readonly List<string> _restaurants = new List<string>()
        {
            "'Taco Bell'",
            "'McDonalds'",
            "'Chic-fil-a'",
            "'Chipotle'",
            "'Subway'",
            "'Jimmy Johns'",
            "'Starbucks'",
            "'Panda Express'",
            "'In-and-Out'",
            "'Dunkin Donuts'",
        };

        public override void Up()
        {
            foreach (var r in _restaurants)
            {
                Sql($"INSERT INTO Restaurants (Name) VALUES ({r})");
            }
        }
        
        public override void Down()
        {
            foreach (var r in _restaurants)
            {
                Sql($"DELETE FROM Restaurants WHERE Name == {r}");
            }
        }
    }
}
