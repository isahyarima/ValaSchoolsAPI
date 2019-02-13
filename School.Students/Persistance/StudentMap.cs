using School.Students.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Students.Persistance
{
    public class StudentMap : EntityTypeConfiguration<Student>
    {
        public StudentMap()
        {
            Property(o => o.DateOfBirth).IsRequired()
                .HasMaxLength(20);
            Property(o => o.FirstName).IsRequired()
                .HasMaxLength(50);
            Property(o => o.LastName).IsRequired()
                .HasMaxLength(50);
            Property(o => o.MiddleName)
                .HasMaxLength(50);
            Property(o => o.NativeLaguage).IsRequired()
                .HasMaxLength(50);
            Property(o => o.Religion).IsRequired()
                .HasMaxLength(20);
            Property(o => o.StudentId).IsRequired()
                .HasMaxLength(20);
            Property(o => o.LocalGovt).HasMaxLength(100).IsRequired();
            Property(o => o.StateOfOrigin).HasMaxLength(100).IsRequired();
            Property(o => o.Gender).HasMaxLength(10).IsRequired()
             ;
        }
    }
}
