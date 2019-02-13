using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Business.Origin;

namespace School.Data.OriginPersistance
{
    public class LGAMap : IEntityTypeConfiguration<LGA>
    {
        public void Configure(EntityTypeBuilder<LGA> builder)
        {
            builder.Ignore(o => o.EntityId);
            builder.Property(o => o.LgaName).HasMaxLength(100);
            builder.HasKey(o => o.LgaId);
            builder.Property(o => o.StateId);
        }
    }
}
