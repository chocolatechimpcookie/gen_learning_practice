using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood2.Models;

namespace OdeToFood2.Data
{
    public class OdeToFood2DbContext : DbContext
    {

        public OdeToFood2DbContext(DbContextOptions options)
            :base(options)
        {
            
        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
