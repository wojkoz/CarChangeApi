using CarChangeApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarChangeApi.Domain.DatabaseContext.config
{
    public class AdvertisementEntityConfiguration : IEntityTypeConfiguration<Advertisement>
    {
        public void Configure(EntityTypeBuilder<Advertisement> builder)
        {
            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar");

            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(500)
                .HasColumnType("varchar");

            builder.Property(x => x.Location)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar");

            builder.Property(x => x.Price)
                .IsRequired()
                .HasColumnType("smallmoney");

            builder.Property(x => x.CreatedAt)
                .IsRequired()
                .HasColumnType("smalldatetime");

            builder.Property(x => x.Ends)
                .IsRequired()
                .HasColumnType("smalldatetime");

            builder.Property(x => x.UserId)
                .IsRequired();
        }

    }
}
