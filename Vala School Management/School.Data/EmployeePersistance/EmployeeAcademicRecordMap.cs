using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Business.Employees;

namespace School.Data
{
    public class EmployeeAcademicRecordMap : IEntityTypeConfiguration<EmployeeAcademicRecord>
    {
        public void Configure(EntityTypeBuilder<EmployeeAcademicRecord> builder)
        {
            builder.Property(o => o.CertificateObtained).HasMaxLength(100);
            builder.Property(o => o.SchoolName).HasMaxLength(500);
            builder.Ignore(o => o.EntityId);
            builder.Property(o => o.EmployeeId).HasMaxLength(20);
        }
    }
}
