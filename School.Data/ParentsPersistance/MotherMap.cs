using School.Business.Parents;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.ParentsPersistance
{
   public class MotherMap : EntityTypeConfiguration<Mother>
    {
        public MotherMap()
        {
            Ignore(o => o.EntityId);
            Property(o => o.Address).HasMaxLength(500).IsOptional();
            Property(o => o.Email).HasMaxLength(200).IsOptional();
            Property(o => o.MotherId).HasMaxLength(500);
            HasKey(o => o.MotherId);
            Property(o => o.FirstName).HasMaxLength(20).IsOptional();
            Property(o => o.Gender).HasMaxLength(10).IsOptional();
            Property(o => o.LastName).HasMaxLength(20).IsOptional();
            Property(o => o.MiddleName).HasMaxLength(20).IsOptional();
            Property(o => o.Occupation).HasMaxLength(200).IsOptional();
            Property(o => o.PhoneNumber).HasMaxLength(20).IsOptional();
            Property(o => o.SchoolCode).HasMaxLength(20).IsOptional();
            Property(o => o.StudentId).HasMaxLength(20).IsOptional();
        }
    }
}
