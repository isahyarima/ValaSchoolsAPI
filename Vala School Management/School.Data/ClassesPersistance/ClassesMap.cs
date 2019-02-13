using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Business.Classes;

namespace School.Data.ClassesPersistance
{
    public class ClassesMap : IEntityTypeConfiguration<Classes>
    {
        public void Configure(EntityTypeBuilder<Classes> builder)
        {
            builder.Property(o => o.ClassAccronym).HasMaxLength(20);
            builder.HasKey(o => o.ClassId);
            builder.Property(o=>o.ClassId);
            builder.Property(o => o.ClassName).HasMaxLength(500);
            builder.Property(o => o.ClassRef).HasMaxLength(20);
            builder.Property(o => o.DateCreated).HasMaxLength(50);
            builder.Ignore(o => o.EntityId);
        }
    }
}
