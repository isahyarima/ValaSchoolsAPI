using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Business.Students;

namespace School.Data
{
    public class StudentContactMap : IEntityTypeConfiguration<StudentContact>
    {
        public void Configure(EntityTypeBuilder<StudentContact> builder)
        {
            builder.Ignore(o => o.EntityId);
            builder.Property(o => o.Email)
                .HasMaxLength(100);
            builder.Property(o => o.HomeAddress)
                .HasMaxLength(500);
            builder.Property(o => o.PhoneNumber)
                .HasMaxLength(20);
            builder.Property(o => o.StudentContactId)
                .IsRequired();
        }
    }
}
