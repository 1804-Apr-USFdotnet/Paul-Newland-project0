using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRestaurantsProject0.DataModels
{
    class ReviewRepo
    {
        private readonly ApplicationDbContext _context;

        public ReviewRepo()
        {
            _context = new ApplicationDbContext();
        }

        public List<Review> GetReviews()
        {
            return _context.Reviews.ToList();
        }

        public Review GetReview(int id)
        {
            return _context.Reviews.SingleOrDefault(r => r.Id == id);
        }

        public void CreateReview(Restaurant restaurant, string description, int rating)
        {
            var review = new Review() {Restaurant = restaurant, Description = description, Rating = rating};
            _context.Reviews.Add(review);
            _context.SaveChanges();
        }

        public void UpdateReview(int id, string description = "", int rating = 0)
        {
            var review = GetReview(id);

            if (!String.IsNullOrEmpty(description))
                review.Description = description;
            if (rating != 0)
                review.Rating = rating;

            _context.SaveChanges();
        }

        public void DeleteReview(int id)
        {
            var review = GetReview(id);

            _context.Reviews.Remove(review);
            _context.SaveChanges();
        }
    }
}