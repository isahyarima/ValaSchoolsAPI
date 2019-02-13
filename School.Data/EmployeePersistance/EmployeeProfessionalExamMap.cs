using School.Business.Employees;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data
{
    public class EmployeeProfessionalExamMap : EntityTypeConfiguration<EmployeeProfessionalExam>
    {
        public EmployeeProfessionalExamMap()
        {
            Property(o => o.ExamBody).HasMaxLength(50).IsOptional();
            Property(o => o.ExamDate).HasMaxLength(20).IsOptional();
            Property(o => o.CertificationName).HasMaxLength(50).IsOptional();
            Ignore(o => o.EntityId);
            Property(o => o.SchoolCode).HasMaxLength(20).IsOptional();
        }
    }
}
