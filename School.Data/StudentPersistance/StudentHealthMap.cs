using School.Business.Students;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data
{
   public  class StudentHealthMap : EntityTypeConfiguration<StudentHealth>
    {
        public StudentHealthMap()
        {
            Property(o => o.BloodGroup)
                .HasMaxLength(10).IsOptional();
            Property(o => o.EarStatus)
                .HasMaxLength(10).IsOptional();
            Property(o => o.EyeStatus)
                .HasMaxLength(10).IsOptional();
            Property(o => o.PrequestCases)
                .HasMaxLength(500).IsOptional();
            Property(o => o.Temperament)
                .HasMaxLength(100).IsOptional();
            Ignore(o => o.EntityId);
            Property(o => o.SchoolCode).HasMaxLength(20).IsOptional();

        }
    }
}
