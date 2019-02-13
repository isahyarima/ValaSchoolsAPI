using School.Business.Employees;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data
{
    public class EmployeeAcademicRecordMap : EntityTypeConfiguration<EmployeeAcademicRecord>
    {
        public EmployeeAcademicRecordMap()
        {
            Property(o => o.CertificateObtained).HasMaxLength(100).IsOptional();
            Property(o => o.SchoolName).HasMaxLength(500).IsOptional();
            Ignore(o => o.EntityId);
            Property(o => o.SchoolCode).HasMaxLength(20).IsOptional();
            Property(o => o.EmployeeId).HasMaxLength(20).IsOptional();
        }
    }
}
