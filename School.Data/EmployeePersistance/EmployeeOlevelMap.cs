using School.Business.Employees;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data
{
    public class EmployeeOlevelMap : EntityTypeConfiguration<EmployeeOlevel>
    {
        public EmployeeOlevelMap()
        {
            HasKey(o => o.EmployeeOlevelId);
            Property(o => o.ExamBatch).HasMaxLength(80).IsOptional();
            Property(o => o.ExamNumber).HasMaxLength(20).IsOptional();
            Property(o => o.ExamYear).HasMaxLength(20).IsOptional();
            Property(o => o.Grade).HasMaxLength(10).IsOptional();
            Property(o => o.SchoolAddress).HasMaxLength(500).IsOptional();
            Property(o => o.SchoolName).HasMaxLength(500).IsOptional();
            Property(o => o.Subject).HasMaxLength(100).IsOptional();
            Ignore(o => o.EntityId);
            Property(o => o.SchoolCode).HasMaxLength(20).IsOptional();
        }
    }
}
