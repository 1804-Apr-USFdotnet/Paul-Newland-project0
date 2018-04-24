using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRestaurantsProject0.DataModels
{
    public class Review
    {
        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
    }
}
