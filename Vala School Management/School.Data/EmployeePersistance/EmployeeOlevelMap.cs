using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Business.Employees;

namespace School.Data
{
    public class EmployeeOlevelMap : IEntityTypeConfiguration<EmployeeOlevel>
    {
        public void Configure(EntityTypeBuilder<EmployeeOlevel> builder)
        {
            builder.HasKey(o => o.EmployeeOlevelId);
            builder.Property(o => o.ExamBatch).HasMaxLength(80);
            builder.Property(o => o.ExamNumber).HasMaxLength(20);
            builder.Property(o => o.ExamYear).HasMaxLength(20);
            builder.Property(o => o.Grade).HasMaxLength(10);
            builder.Property(o => o.SchoolAddress).HasMaxLength(500);
            builder.Property(o => o.SchoolName).HasMaxLength(500);
            builder.Property(o => o.Subject).HasMaxLength(100);
            builder.Ignore(o => o.EntityId);
        }
    }
}
