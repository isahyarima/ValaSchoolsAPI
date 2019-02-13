using School.Business.Employees;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data
{
    public class EmployeeExperiencesMap : EntityTypeConfiguration<EmployeeExperiences>
    {
        public EmployeeExperiencesMap()
        {
            HasKey(o => o.EmployeeExperienceId);
            Property(o => o.EmployerName).HasMaxLength(200).IsOptional();
            Property(o => o.Contribution).HasMaxLength(500).IsOptional();
            Property(o => o.PositionHeld).HasMaxLength(100).IsOptional();
            Ignore(o => o.EntityId);
            Property(o => o.SchoolCode).HasMaxLength(20).IsOptional();
        }
    }
}
