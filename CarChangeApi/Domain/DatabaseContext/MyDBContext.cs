using CarChangeApi.Domain.DatabaseContext.config;
using CarChangeApi.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarChangeApi.Domain.DatabaseContext
{
    public class MyDBContext : IdentityDbContext<User>
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new UserEntityConfiguration().Configure(modelBuilder.Entity<User>());
            new AdvertisementEntityConfiguration().Configure(modelBuilder.Entity<Advertisement>());
            new CarEntityConfiguration().Configure(modelBuilder.Entity<Car>());

            modelBuilder.Entity<Advertisement>()
                .HasOne(a => a.User)
                .WithMany(u => u.Advertisements)
                .HasForeignKey(a => a.UserId);
        }

        public virtual DbSet<Advertisement> Advertisements { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
    }
}
