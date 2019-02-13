using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Business.Origin;

namespace School.Data.OriginPersistance
{
    public class CountryMap : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.Ignore(o => o.EntityId);
            builder.HasKey(o => o.CountryId);
            builder.Property(o => o.CountryName).HasMaxLength(100);
        }
    }
}
