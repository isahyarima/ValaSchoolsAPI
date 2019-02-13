using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Business.Origin;

namespace School.Data.OriginPersistance
{
    public class StateOfOriginMap : IEntityTypeConfiguration<StateOfOrigin>
    {
        public void Configure(EntityTypeBuilder<StateOfOrigin> builder)
        {
            builder.Ignore(o => o.EntityId);
            builder.HasKey(o => o.StateId);
            builder.Property(o => o.CountryId);
            builder.Property(o => o.StateName).HasMaxLength(100);

        }
    }
}
