using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace minidemo.Models
{
    class FoodContext:DbContext
    {
        public FoodContext() : base("FoodServiceDB"){
            //Database.SetInitializer(new DropCreateDatabaseAlways<FoodContext>());
        }

        public DbSet<Areapin> Areapins { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Order> Orders { get; set; }
        
    }
}
