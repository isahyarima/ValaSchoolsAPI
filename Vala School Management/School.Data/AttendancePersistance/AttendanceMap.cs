using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Business.Attendance;

namespace School.Data.AttendancePersistance
{
    public class AttendanceMap : IEntityTypeConfiguration<Attendance>
    {
        public void Configure(EntityTypeBuilder<Attendance> builder)
        {
            builder.Ignore(o => o.EntityId);
            builder.Property(o => o.AttendanceDate).HasMaxLength(50);
            builder.Property(o => o.AttendanceDesc).HasMaxLength(100);
            builder.Property(o => o.AttendanceId);
            builder.HasKey(o => o.AttendanceId);
            builder.Property(o => o.AttendanceStatus).HasMaxLength(5);
            builder.Property(o => o.ClassId).HasMaxLength(20);
            builder.Property(o => o.Day).HasMaxLength(20);
            builder.Property(o => o.Month).HasMaxLength(20);
            builder.Property(o => o.RegistrationNumber).HasMaxLength(20);
            builder.Property(o => o.Remark).HasMaxLength(200);
            builder.Property(o => o.SectionId).HasMaxLength(20);
            builder.Property(o => o.Session).HasMaxLength(20);
            builder.Property(o => o.StudentId).HasMaxLength(20);
        }
    }
}
