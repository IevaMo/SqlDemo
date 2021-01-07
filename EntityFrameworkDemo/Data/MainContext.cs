using EntityFrameworkDemo.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EntityFrameworkDemo.Data
{
    public class MainContext : DbContext
    {
        public DbSet<Fruit> Fruits { get; set; }

        public DbSet<User> Users { get; set; }

        public MainContext(DbContextOptions<MainContext> options) : base(options)
        {
            if (!Users.Any())
            {
                Users.Add(new User()
                {
                    FirstName = "Ieva",
                    LastName = "Mockute"
                });

                Users.Add(new User()
                {
                    FirstName = "Mantas",
                    LastName = "Mele"
                });

                SaveChanges();
            }
        
        }
    }
}
