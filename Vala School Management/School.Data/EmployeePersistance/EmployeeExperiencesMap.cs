using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Business.Employees;

namespace School.Data
{
    public class EmployeeExperiencesMap : IEntityTypeConfiguration<EmployeeExperiences>
    {
        public void Configure(EntityTypeBuilder<EmployeeExperiences> builder)
        {
            builder.HasKey(o => o.EmployeeExperienceId);
            builder.Property(o => o.EmployerName).HasMaxLength(200);
            builder.Property(o => o.Contribution).HasMaxLength(500);
            builder.Property(o => o.PositionHeld).HasMaxLength(100);
            builder.Ignore(o => o.EntityId);
        }
    }
}
