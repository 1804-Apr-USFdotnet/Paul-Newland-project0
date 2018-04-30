using System.Collections.Generic;
using ConsoleRestaurantsProject0.DataModels;

namespace ConsoleRestaurantsProject0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReferenceDataToReviews : DbMigration
    {
        private readonly List<Review> _reviews = new List<Review>()
        {
            new Review(){Id = 1, RestaurantId = 2, Rating = 1},
            new Review(){Id = 2, RestaurantId = 3, Rating = 2},
            new Review(){Id = 3, RestaurantId = 4, Rating = 3},
            new Review(){Id = 4, RestaurantId = 5, Rating = 4},
            new Review(){Id = 5, RestaurantId = 6, Rating = 5},
            new Review(){Id = 6, RestaurantId = 7, Rating = 6},
            new Review(){Id = 7, RestaurantId = 8, Rating = 7},
            new Review(){Id = 8, RestaurantId = 9, Rating = 8},
            new Review(){Id = 9, RestaurantId = 10, Rating = 9},
            new Review(){Id = 10, RestaurantId = 11, Rating = 10},
            new Review(){Id = 11, RestaurantId = 2, Rating = 5},
            new Review(){Id = 12, RestaurantId = 3, Rating = 5},
            new Review(){Id = 13, RestaurantId = 4, Rating = 5},
            new Review(){Id = 14, RestaurantId = 5, Rating = 5},
            new Review(){Id = 15, RestaurantId = 6, Rating = 5},
            new Review(){Id = 16, RestaurantId = 7, Rating = 5},
            new Review(){Id = 17, RestaurantId = 8, Rating = 5},
            new Review(){Id = 18, RestaurantId = 9, Rating = 5},
            new Review(){Id = 19, RestaurantId = 10, Rating = 5},
            new Review(){Id = 20, RestaurantId = 11, Rating = 5},
        };

        public override void Up()
        {
            foreach (var r in _reviews)
            {
                Sql($"INSERT INTO Reviews (Rating, RestaurantId) VALUES ({r.Rating}, {r.RestaurantId})");
            }
        }
        
        public override void Down()
        {
            foreach (var r in _reviews)
            {
                Sql($"DELETE FROM Reviews WHERE Id == {r.Id}");
            }
        }
    }
}
