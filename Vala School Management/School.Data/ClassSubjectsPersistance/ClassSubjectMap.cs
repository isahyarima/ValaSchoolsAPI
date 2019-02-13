using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Business.ClassSubjects.Entities;

namespace School.Data.ClassSubjectsPersistance
{
    public class ClassSubjectMap : IEntityTypeConfiguration<ClassSubjects>
    {
        public void Configure(EntityTypeBuilder<ClassSubjects> builder)
        {
            builder.Property(o => o.ClassId).HasMaxLength(20) ;
            builder.HasKey(O => O.ClassSubjectsId);
            builder.Property(O => O.ClassSubjectsId);
            builder.Property(o => o.DateCreated).HasMaxLength(50);
            builder.Ignore(o => o.EntityId);
            builder.Property(o => o.SubjectsId).HasMaxLength(20);
        }
    }
}
