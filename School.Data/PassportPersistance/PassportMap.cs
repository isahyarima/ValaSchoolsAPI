using School.Business.Passport;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data
{
    class PassportMap : EntityTypeConfiguration<RegistrationPassport>
    {
        public PassportMap()
        {
            Property(o => o.CreatedBy).HasMaxLength(200).IsOptional();
            Property(o => o.CreatedFrom).HasMaxLength(200).IsOptional();
            Property(o => o.EditedBy).HasMaxLength(200).IsOptional();
            Property(o => o.EditedFrom).HasMaxLength(200).IsOptional();
            Property(o => o.ImageExtention).HasMaxLength(10).IsOptional();
            Property(o => o.ImageName).HasMaxLength(200).IsOptional();
            Property(o => o.ImagePath).HasMaxLength(500).IsOptional();
            Property(o => o.ImageSize).HasMaxLength(10).IsOptional();
            Property(o => o.ImageStatus).HasMaxLength(20).IsOptional();
            Property(o => o.PersonId).HasMaxLength(20).IsOptional();
            HasKey(o => o.RegistrationPassportsId);
            Property(o => o.PersonId).HasMaxLength(20).IsOptional();
            Ignore(o => o.EntityId);
            Property(o => o.SchoolCode).HasMaxLength(20).IsOptional();

        }
    }
}
