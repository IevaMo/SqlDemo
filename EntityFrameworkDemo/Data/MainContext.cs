using EntityFrameworkDemo.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EntityFrameworkDemo.Data
{
    public class MainContext : DbContext
    {
        public DbSet<Fruit> Fruits { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<User> Users { get; set; }

        public MainContext(DbContextOptions<MainContext> options) : base(options)
        {

            Database.Migrate();

            if (!Users.Any()) // Patikrinama ar yra duomenu bazeje
               {
                   Users.Add(new User()
                   {
                       FirstName = "Ieva",
                       LastName = "Mockute",
                       Deleted = false
                   });

                   Users.Add(new User()
                   {
                       FirstName = "Mantas",
                       LastName = "Mele",
                       Deleted = false
                   });

                   SaveChanges();
               }

        }
    }
}
