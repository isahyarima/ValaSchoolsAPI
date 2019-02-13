using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Business.Employees;

namespace School.Data
{
    public class EmployeeMap : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(o => o.DatetOfBirth).HasMaxLength(50).IsRequired();
            builder.Property(o => o.EmployeeId).HasMaxLength(20).IsRequired();
            builder.Property(o => o.Gender).HasMaxLength(10).IsRequired();
            builder.Property(o => o.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(o => o.LastName).HasMaxLength(50).IsRequired();
            builder.Property(o => o.LocalGovt).HasMaxLength(100).IsRequired();
            builder.Property(o => o.MiddleName).HasMaxLength(50);
            builder.Property(o => o.NativeLaguage).HasMaxLength(100).IsRequired();
            builder.Property(o => o.Religion).HasMaxLength(50);
            builder.Property(o => o.StateOfOrigin).HasMaxLength(100).IsRequired();
            builder.Ignore(o => o.EntityId);
        }
    }
}
