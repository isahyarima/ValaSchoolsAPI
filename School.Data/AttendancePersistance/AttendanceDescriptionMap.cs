using School.Business.Attendance;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.AttendancePersistance
{
    public class AttendanceDescriptionMap : EntityTypeConfiguration<AttendanceDescription>
    {
        public AttendanceDescriptionMap()
        {
            Ignore(o => o.EntityId);
            Property(o => o.AttendanceDescId).IsRequired();
                HasKey(o => o.AttendanceDescId);
            Property(o => o.SchoolCode).HasMaxLength(20).IsOptional();
        }
    }
}
