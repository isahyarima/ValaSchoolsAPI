using School.Students.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Students.Persistance
{
   public  class StudentHealthMap : EntityTypeConfiguration<StudentHealth>
    {
        public StudentHealthMap()
        {
            Property(o => o.BloodGroup)
                .HasMaxLength(10);
            Property(o => o.EarStatus)
                .HasMaxLength(10);
            Property(o => o.EyeStatus)
                .HasMaxLength(10);
            Property(o => o.PrequestCases)
                .HasMaxLength(500);
            Property(o => o.Temperament)
                .HasMaxLength(100);
        }
    }
}
