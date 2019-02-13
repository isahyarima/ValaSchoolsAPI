using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Business.Employees;

namespace School.Data
{
    public class EmployeeProfessionalExamMap : IEntityTypeConfiguration<EmployeeProfessionalExam>
    {
        public void Configure(EntityTypeBuilder<EmployeeProfessionalExam> builder)
        {
            builder.Property(o => o.ExamBody).HasMaxLength(50);
            builder.Property(o => o.ExamDate).HasMaxLength(20);
            builder.Property(o => o.CertificationName).HasMaxLength(50);
            builder.Ignore(o => o.EntityId);
        }
    }
}
