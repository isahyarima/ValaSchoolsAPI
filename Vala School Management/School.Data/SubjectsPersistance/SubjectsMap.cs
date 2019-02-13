using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Business.Subjects;

namespace School.Data.SubjectsPersistance
{
    class SubjectsMap : IEntityTypeConfiguration<Subjects>
    {
        public void Configure(EntityTypeBuilder<Subjects> builder)
        {
            builder.Ignore(o => o.EntityId);
            builder.Property(o => o.SubjectAccronym).HasMaxLength(10);
            builder.Property(o => o.SubjectName).HasMaxLength(500);
            builder.HasKey(o => o.SubjectsId);
        }
    }
}
