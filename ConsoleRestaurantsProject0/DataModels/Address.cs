using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRestaurantsProject0.DataModels
{
    public class Address
    {
        public int Id { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public string Steet { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}
