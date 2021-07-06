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
        }
    }
}
