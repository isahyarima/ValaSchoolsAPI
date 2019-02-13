using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Business.School;

namespace School.Data.SchoolPersistance
{
    public class SchoolInformationMap : IEntityTypeConfiguration<SchoolInformation>
    {
        public void Configure(EntityTypeBuilder<SchoolInformation> builder)
        {
            builder.Ignore(o => o.EntityId);
            builder.Property(o => o.SchoolCode).HasMaxLength(20);
            builder.Property(o => o.SchoolName).HasMaxLength(200);
        }
    }
}
