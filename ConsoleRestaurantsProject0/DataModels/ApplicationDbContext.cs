using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRestaurantsProject0.DataModels
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public ApplicationDbContext()
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurant>()
                .HasRequired(r => r.Address)
                .WithRequiredPrincipal(a => a.Restaurant);

            modelBuilder.Entity<Restaurant>()
                .HasMany(r => r.Reviews)
                .WithRequired(r => r.Restaurant)
                .HasForeignKey(r => r.RestaurantId);
        }
    }
}
