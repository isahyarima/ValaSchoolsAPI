using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Business.ClassEnrolment;

namespace School.Data.ClassEnrolmentPersistance
{
    class ClassEnrolmentMap : IEntityTypeConfiguration<ClassEnrolment>
    {
        public void Configure(EntityTypeBuilder<ClassEnrolment> builder)
        {
            builder.Ignore(o => o.EntityId);
            builder.Property(o => o.ClassEnrolmentId);
            builder.HasKey(o => o.ClassEnrolmentId) ;
            builder.Property(o => o.RegistrationNumber).HasMaxLength(20);

        }
    }
}
