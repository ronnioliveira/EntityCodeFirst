using CodeFirst.Entity;
using System.Data.Entity;

namespace CodeFirst.Data
{
    public class CarStoreContext : DbContext
    {
        public CarStoreContext() : base()
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Store> Stores { get; set; }
    }
}
