using School.Business.GradeSetting;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.GradeSettingPersistance
{
    public class GradeSettingMap : EntityTypeConfiguration<GradeSetting>
    {
        public GradeSettingMap()
        {
            Property(o => o.ClassesId).HasMaxLength(20).IsOptional();
            HasKey(o => o.GradeId);
            Property(o => o.Grade).HasMaxLength(5).IsOptional();
            Property(o => o.GradeDescription).HasMaxLength(20).IsOptional();
            Property(o => o.Remark).HasMaxLength(200).IsOptional();
            Property(o => o.SchoolCode).HasMaxLength(20).IsOptional();
            Property(o => o.SubjectsId).HasMaxLength(20).IsOptional();
            Ignore(o => o.EntityId);
        }
    }
}
