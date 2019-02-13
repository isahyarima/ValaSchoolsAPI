using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Business.Passport;

namespace School.Data
{
    class PassportMap : IEntityTypeConfiguration<RegistrationPassport>
    {
        public void Configure(EntityTypeBuilder<RegistrationPassport> builder)
        {
            builder.Property(o => o.CreatedBy).HasMaxLength(200);
            builder.Property(o => o.CreatedFrom).HasMaxLength(200);
            builder.Property(o => o.ImageExtention).HasMaxLength(10);
            builder.Property(o => o.ImageName).HasMaxLength(200);
            builder.Property(o => o.ImagePath).HasMaxLength(500);
            builder.Property(o => o.ImageSize).HasMaxLength(10);
            builder.Property(o => o.ImageStatus).HasMaxLength(20);
            builder.Property(o => o.PersonId).HasMaxLength(20);
            builder.HasKey(o => o.RegistrationPassportsId);
            builder.Property(o => o.PersonId).HasMaxLength(20);
            builder.Ignore(o => o.EntityId);

        }
    }
}
