using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext() : base("RestaurantDb")
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }

    }
}
