using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Business.Session;

namespace School.Data.AcademicSettingPersistance
{
    public class AssessmentSettingMap : IEntityTypeConfiguration<AssessmentSetting>
    {
        public void Configure(EntityTypeBuilder<AssessmentSetting> builder)
        {
           builder.Ignore(o => o.EntityId);
           builder.HasKey(o => o.AssessmentSettingId);
           builder.Property(o => o.AssessmentType).HasMaxLength(20);
           builder.Property(o => o.ClassId).HasMaxLength(20);
           builder.Property(o => o.Scores);
           builder.Property(o => o.SectionId).HasMaxLength(20);
            builder.Property(o => o.Session).HasMaxLength(20);
        }
    }
}
