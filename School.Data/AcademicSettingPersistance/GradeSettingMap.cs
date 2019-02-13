using School.Business.GradeSetting;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.AcademicSettingPersistance
{
   public class GradeSettingMap : EntityTypeConfiguration<GradeSetting>
    {
        public GradeSettingMap()
        {
            Ignore(o => o.EntityId);
            HasKey(o => o.GradeId);
            Property(o => o.Grade).HasMaxLength(10).IsOptional();
            Property(o => o.GradeDescription).HasMaxLength(50).IsOptional();
            Property(o => o.ClassesId).HasMaxLength(10).IsOptional();
            Property(o => o.MaxScore).IsOptional();
            Property(o => o.MinScore).IsOptional();
            Property(o => o.Remark).HasMaxLength(200).IsOptional();
            Property(o => o.SchoolCode).HasMaxLength(20).IsOptional();
            Property(o => o.SubjectsId).HasMaxLength(20).IsOptional();
        }
    }
}
