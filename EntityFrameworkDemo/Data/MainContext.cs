using EntityFrameworkDemo.Model;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkDemo.Data
{
    public class MainContext : DbContext
    {
        public DbSet<Fruit> Fruits { get; set; }

       public MainContext(DbContextOptions<MainContext> options) : base(options)
       { }
    }
}
