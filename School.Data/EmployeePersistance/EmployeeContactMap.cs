using School.Business.Employees;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data
{
   public  class EmployeeContactMap : EntityTypeConfiguration<EmployeeContact>
    {
        public EmployeeContactMap()
        {
            HasKey(o => o.EmployeeContactId);
            Property(o => o.Email).HasMaxLength(100).IsOptional();
            Property(o => o.HomeAddress).HasMaxLength(500).IsOptional();
            Property(o => o.PhoneNumber).HasMaxLength(20).IsOptional();
            Ignore(o => o.EntityId);
            Property(o => o.SchoolCode).HasMaxLength(20).IsOptional();
        }
    }
}
