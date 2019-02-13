using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Business.Classes.Entities;

namespace School.Data.ClassesPersistance
{
    public class SectionMap : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            builder.HasKey(o => o.SectionId);
            builder.Property(o => o.ClassId).HasMaxLength(20);
            builder.Property(o => o.SectionName).HasMaxLength(20);
            builder.Ignore(o => o.EntityId);
        }
    }
}
