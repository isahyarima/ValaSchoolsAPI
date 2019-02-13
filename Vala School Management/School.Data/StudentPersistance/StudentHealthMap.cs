using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Business.Students;

namespace School.Data
{
    public  class StudentHealthMap : IEntityTypeConfiguration<StudentHealth>
    {
        public void Configure(EntityTypeBuilder<StudentHealth> builder)
        {
            builder.Property(o => o.BloodGroup)
                .HasMaxLength(10);
            builder.Property(o => o.EarStatus)
                .HasMaxLength(10);
            builder.Property(o => o.EyeStatus)
                .HasMaxLength(10);
            builder.Property(o => o.PrequestCases)
                .HasMaxLength(500);
            builder.Property(o => o.Temperament)
                .HasMaxLength(100);
            builder.Ignore(o => o.EntityId);

        }
    }
}
