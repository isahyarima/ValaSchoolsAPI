using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Business.Students;

namespace School.Data
{
    public class StudentMap : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(o => o.DateOfBirth).IsRequired()
                .HasMaxLength(20);
            builder.Property(o => o.FirstName).IsRequired()
                .HasMaxLength(50);
            builder.Property(o => o.LastName).IsRequired()
                .HasMaxLength(50);
            builder.Property(o => o.MiddleName)
                .HasMaxLength(50);
            builder.Property(o => o.NativeLaguage).IsRequired()
                .HasMaxLength(50);
            builder.Property(o => o.Religion).IsRequired()
                .HasMaxLength(20);
            builder.Property(o => o.StudentId).IsRequired()
                .HasMaxLength(20);
            builder.Property(o => o.LocalGovt).HasMaxLength(100).IsRequired();
            builder.Property(o => o.StateOfOrigin).HasMaxLength(100).IsRequired();
            builder.Property(o => o.Gender).HasMaxLength(10).IsRequired()
             ;
            builder.Ignore(o => o.EntityId);

        }
    }
}
