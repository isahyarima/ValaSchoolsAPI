using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Business.GradeSetting;

namespace School.Data.AcademicSettingPersistance
{
    public class GradeSettingMap : IEntityTypeConfiguration<GradeSetting>
    {
        public void Configure(EntityTypeBuilder<GradeSetting> builder)
        {
            builder.Ignore(o => o.EntityId);
            builder.HasKey(o => o.GradeId);
            builder.Property(o => o.Grade).HasMaxLength(10);
            builder.Property(o => o.GradeDescription).HasMaxLength(50);
            builder.Property(o => o.ClassesId).HasMaxLength(10);
            builder.Property(o => o.MaxScore);
            builder.Property(o => o.MinScore);
            builder.Property(o => o.Remark).HasMaxLength(200);
            builder.Property(o => o.SubjectsId).HasMaxLength(20);
        }
    }
}
