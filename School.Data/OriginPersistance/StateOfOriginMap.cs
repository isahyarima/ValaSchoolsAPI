using School.Business.Origin;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.OriginPersistance
{
    public class StateOfOriginMap : EntityTypeConfiguration<StateOfOrigin>
    {
        public StateOfOriginMap()
        {
            Ignore(o => o.EntityId);
            HasKey(o => o.StateId);
            Property(o => o.CountryId);
            Property(o => o.StateName).HasMaxLength(100).IsOptional();

        }
    }
}
