using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleRestaurantsProject0.DataModels;
using Newtonsoft.Json;


namespace ConsoleRestaurantsProject0
{
    public class Serializer
    {
        private readonly ApplicationDbContext _context;

        public Serializer()
        {
            _context = new ApplicationDbContext();
        }

        public string GetRestaurantsJson()
        {
            var restaurants = _context.Restaurants.ToList();
            return JsonConvert.SerializeObject(restaurants);
        }

        public string GetReviewsJson()
        {
            var reviews = _context.Reviews.ToList();
            return JsonConvert.SerializeObject(reviews);
        }

        public List<T> ImportObjectsListJson<T>(string file)
        {
            var list = new List<T>();

            var serializer = new JsonSerializer();

            using (var sw = new StreamWriter($@"{file}"))
            using (var writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, list);
            }
            
            return list;
        }
    }
}
