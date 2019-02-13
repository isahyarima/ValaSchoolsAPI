using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Business.Attendance;

namespace School.Data.AttendancePersistance
{
    public class AttendanceDescriptionMap : IEntityTypeConfiguration<AttendanceDescription>
    {
        public void Configure(EntityTypeBuilder<AttendanceDescription> builder)
        {
            builder.Ignore(o => o.EntityId);
            builder.Property(o => o.AttendanceDescId).IsRequired();
            builder.HasKey(o => o.AttendanceDescId);
        }
    }
}
