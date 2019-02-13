using School.Business.Employees;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            Property(o => o.DateOfBirth).HasMaxLength(50).IsRequired();
            Property(o => o.EmployeeId).HasMaxLength(20).IsRequired();
            Property(o => o.Gender).HasMaxLength(10).IsRequired();
            Property(o => o.FirstName).HasMaxLength(50).IsRequired();
            Property(o => o.LastName).HasMaxLength(50).IsRequired();
            Property(o => o.LocalGovt).HasMaxLength(100).IsRequired();
            Property(o => o.MiddleName).HasMaxLength(50).IsOptional();
            Property(o => o.NativeLaguage).HasMaxLength(100).IsRequired();
            Property(o => o.Religion).HasMaxLength(50).IsOptional();
            Property(o => o.StateOfOrigin).HasMaxLength(100).IsRequired();
            Ignore(o => o.EntityId);
            Property(o => o.SchoolCode).HasMaxLength(20).IsOptional();
        }
    }
}
