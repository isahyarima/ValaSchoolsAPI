using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Business.Students;

namespace School.Data
{
    public class StudentGuardianMap : IEntityTypeConfiguration<StudentGuardian>
    {
        public void Configure(EntityTypeBuilder<StudentGuardian> builder)
        {
            builder.Ignore(o => o.EntityId);
            builder.Property(o => o.DateOfBirth)
                .HasMaxLength(20);
            builder.Property(o => o.Email)
                .HasMaxLength(100);
            builder.Property(o => o.FirstName)
                .HasMaxLength(20);
            builder.Property(o => o.Gender)
                .HasMaxLength(10);
            builder.Property(o => o.StudentGuardianId)
                .IsRequired();
            builder.Property(o => o.HomeAddress)
                .HasMaxLength(500);
            builder.Property(o => o.LastName)
                .HasMaxLength(20);
            builder.Property(o => o.LocalGovt)
                .HasMaxLength(100);
            builder.Property(o => o.MiddleName)
                .HasMaxLength(20);
            builder.Property(o => o.OfficeAddress)
                .HasMaxLength(500);
            builder.Property(o => o.OfficeNumber)
                .HasMaxLength(20);
            builder.Property(o => o.PhoneNumber)
                .HasMaxLength(20);
            builder.Property(o => o.Relationship)
                .HasMaxLength(100);
            builder.Property(o => o.StateOfOrigin)
                .HasMaxLength(100);
        }
    }
}
