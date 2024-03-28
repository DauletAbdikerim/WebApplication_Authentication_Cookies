using Microsoft.EntityFrameworkCore;
using WebApplication_Authentication_Cookies;

namespace WebApplication_Authentication_Cookies
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                    new User { Id = 1, Email = "tom@mail.com",  Password = "12345" },
                    new User { Id = 2, Email = "tom@mail.com", Password = "12345" },
                    new User { Id = 3, Email = "Ali@mail.com",  Password = "55555" }
                 
            );
        }
    }
}
