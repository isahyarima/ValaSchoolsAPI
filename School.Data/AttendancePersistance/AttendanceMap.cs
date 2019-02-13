using School.Business.Attendance;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.AttendancePersistance
{
   public class AttendanceMap : EntityTypeConfiguration<Attendance>
    {
        public AttendanceMap()
        {
            Ignore(o => o.EntityId);
            Property(o => o.AttendanceDate).HasMaxLength(50).IsOptional();
            Property(o => o.AttendanceDesc).HasMaxLength(100).IsOptional();
            Property(o => o.AttendanceId).IsOptional();
            HasKey(o => o.AttendanceId);
            Property(o => o.AttendanceStatus).HasMaxLength(5).IsOptional();
            Property(o => o.ClassId).HasMaxLength(20).IsOptional();
            Property(o => o.Day).HasMaxLength(20).IsOptional();
            Property(o => o.Month).HasMaxLength(20).IsOptional();
            Property(o => o.RegistrationNumber).HasMaxLength(20).IsOptional();
            Property(o => o.Remark).HasMaxLength(200).IsOptional();
            Property(o => o.SchoolCode).HasMaxLength(20).IsOptional();
            Property(o => o.SectionId).HasMaxLength(20).IsOptional();
            Property(o => o.Session).HasMaxLength(20).IsOptional();
            Property(o => o.StudentId).HasMaxLength(20).IsOptional();
        }
    }
}
