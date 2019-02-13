using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Business.Employees;

namespace School.Data
{
    public  class EmployeeContactMap : IEntityTypeConfiguration<EmployeeContact>
    {
        public void Configure(EntityTypeBuilder<EmployeeContact> builder)
        {
            builder.HasKey(o => o.EmployeeContactId);
            builder.Property(o => o.Email).HasMaxLength(100);
            builder.Property(o => o.HomeAddress).HasMaxLength(500);
            builder.Property(o => o.PhoneNumber).HasMaxLength(20);
            builder.Ignore(o => o.EntityId);
        }
    }
}
