using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRestaurantsProject0.DataModels
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Address Address { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
