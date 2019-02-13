using School.Business.Session;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.AcademicSettingPersistance
{
    public class AssessmentSettingMap : EntityTypeConfiguration<AssessmentSetting>
    {
        public AssessmentSettingMap()
        {
            Ignore(o => o.EntityId);
            HasKey(o => o.AssessmentSettingId);
            Property(o => o.AssessmentType).HasMaxLength(20).IsOptional();
            Property(o => o.ClassId).HasMaxLength(20).IsOptional();
            Property(o => o.SchoolCode).HasMaxLength(20).IsOptional();
            Property(o => o.Scores).IsOptional();
            Property(o => o.SectionId).HasMaxLength(20).IsOptional();
            Property(o => o.Session).HasMaxLength(20).IsOptional();
        }
    }
}
