using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OOP.Models;

namespace OOP.Context.EntityConfiguration;

public class LocationEntityConfiguration : IEntityTypeConfiguration<Location>
{
    public void Configure(EntityTypeBuilder<Location> builder)
    {
        builder.HasKey(x => x.Id);

        builder.OwnsOne(x => x.Latitude)
               .Property(x => x.Value)
               .HasColumnName(nameof(Latitude));

        builder.OwnsOne(x => x.Longitude)
               .Property(x => x.Value)
               .HasColumnName(nameof(Longitude));
    }
}