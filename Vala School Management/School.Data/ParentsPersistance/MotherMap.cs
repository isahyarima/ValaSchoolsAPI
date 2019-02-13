using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Business.Parents;

namespace School.Data.ParentsPersistance
{
    public class MotherMap : IEntityTypeConfiguration<Mother>
    {
        public void Configure(EntityTypeBuilder<Mother> builder)
        {
            builder.Ignore(o => o.EntityId);
            builder.Property(o => o.Address).HasMaxLength(500);
            builder.Property(o => o.Email).HasMaxLength(200);
            builder.Property(o => o.MotherId).HasMaxLength(500);
            builder.HasKey(o => o.MotherId);
            builder.Property(o => o.FirstName).HasMaxLength(20);
            builder.Property(o => o.Gender).HasMaxLength(10);
            builder.Property(o => o.LastName).HasMaxLength(20);
            builder.Property(o => o.MiddleName).HasMaxLength(20);
            builder.Property(o => o.Occupation).HasMaxLength(200);
            builder.Property(o => o.PhoneNumber).HasMaxLength(20);
            builder.Property(o => o.StudentId).HasMaxLength(20);
        }
    }
}
