using School.Business.Students;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data
{
   public class StudentGuardianMap : EntityTypeConfiguration<StudentGuardian>
    {
        public StudentGuardianMap()
        {
            Ignore(o => o.EntityId);
            Property(o => o.DateOfBirth)
                .HasMaxLength(20).IsOptional();
            Property(o => o.Email)
                .HasMaxLength(100).IsOptional();
            Property(o => o.FirstName)
                .HasMaxLength(20).IsOptional();
            Property(o => o.Gender)
                .HasMaxLength(10).IsOptional();
            Property(o => o.StudentGuardianId)
                .IsRequired();
            Property(o => o.HomeAddress)
                .HasMaxLength(500).IsOptional();
            Property(o => o.LastName)
                .HasMaxLength(20).IsOptional();
            Property(o => o.LocalGovt)
                .HasMaxLength(100).IsOptional();
            Property(o => o.MiddleName)
                .HasMaxLength(20).IsOptional();
            Property(o => o.OfficeAddress)
                .HasMaxLength(500).IsOptional();
            Property(o => o.OfficeNumber)
                .HasMaxLength(20).IsOptional();
            Property(o => o.PhoneNumber)
                .HasMaxLength(20).IsOptional();
            Property(o => o.Relationship)
                .HasMaxLength(100).IsOptional();
            Property(o => o.StateOfOrigin)
                .HasMaxLength(100).IsOptional();
            Ignore(o => o.EntityId);
            Property(o => o.SchoolCode).HasMaxLength(20).IsOptional();
        }
    }
}
