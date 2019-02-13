using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Business.GradeSetting;

namespace School.Data.GradeSettingPersistance
{
    public class GradeSettingMap : IEntityTypeConfiguration<GradeSetting>
    {
        public void Configure(EntityTypeBuilder<GradeSetting> builder)
        {
            builder.Property(o => o.ClassesId).HasMaxLength(20);
            builder.HasKey(o => o.GradeId);
            builder.Property(o => o.Grade).HasMaxLength(5);
            builder.Property(o => o.GradeDescription).HasMaxLength(20);
            builder.Property(o => o.Remark).HasMaxLength(200);
            builder.Property(o => o.SubjectsId).HasMaxLength(20);
            builder.Ignore(o => o.EntityId);
        }
    }
}
