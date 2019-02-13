using School.Business.Origin;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.OriginPersistance
{
   public class CountryMap : EntityTypeConfiguration<Country>
    {
        public CountryMap()
        {
            Ignore(o => o.EntityId);
            HasKey(o => o.CountryId);
            Property(o => o.CountryName).HasMaxLength(100).IsOptional();
        }
    }
}
