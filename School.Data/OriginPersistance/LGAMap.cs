using School.Business.Origin;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.OriginPersistance
{
    public class LGAMap : EntityTypeConfiguration<LGA>
    {
        public LGAMap()
        {
            Ignore(o => o.EntityId);
            Property(o => o.LgaName).HasMaxLength(100).IsOptional();
            HasKey(o => o.LgaId);
            Property(o => o.StateId);
        }
    }
}
