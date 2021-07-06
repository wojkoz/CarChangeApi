using CarChangeApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarChangeApi.Domain.DatabaseContext.config
{
    public class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.UserName).IsRequired().HasMaxLength(100).HasColumnType("varchar");
            builder.Property(x => x.Email).IsRequired().HasMaxLength(100).HasColumnType("varchar");
        }
    }
}
