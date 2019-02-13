using School.Business.Classes.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.ClassesPersistance
{
   public class SectionMap : EntityTypeConfiguration<Section>
    {
        public SectionMap()
        {
            HasKey(o => o.SectionId);
            Property(o => o.ClassId).HasMaxLength(20).IsOptional();
            Property(o => o.SchoolCode).HasMaxLength(20).IsOptional();
            Property(o => o.SectionName).HasMaxLength(20).IsOptional();
            Ignore(o => o.EntityId);
        }
    }
}
