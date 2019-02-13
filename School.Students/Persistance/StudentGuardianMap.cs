using School.Students.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Students.Persistance
{
   public class StudentGuardianMap : EntityTypeConfiguration<StudentGuardian>
    {
        public StudentGuardianMap()
        {
            Property(o => o.DateOfBirth)
                .HasMaxLength(20);
            Property(o => o.Email)
                .HasMaxLength(100);
            Property(o => o.FirstName)
                .HasMaxLength(20);
            Property(o => o.Gender)
                .HasMaxLength(10);
            Property(o => o.StudentGuardianId)
                .IsRequired();
            Property(o => o.HomeAddress)
                .HasMaxLength(500);
            Property(o => o.LastName)
                .HasMaxLength(20);
            Property(o => o.LocalGovt)
                .HasMaxLength(100);
            Property(o => o.MiddleName)
                .HasMaxLength(20);
            Property(o => o.OfficeAddress)
                .HasMaxLength(500);
            Property(o => o.OfficeNumber)
                .HasMaxLength(20);
            Property(o => o.PhoneNumber)
                .HasMaxLength(20);
            Property(o => o.Relationship)
                .HasMaxLength(100);
            Property(o => o.StateOfOrigin)
                .HasMaxLength(100);
        }
    }
}
