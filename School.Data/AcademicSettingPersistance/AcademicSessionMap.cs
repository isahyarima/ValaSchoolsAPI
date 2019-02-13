using School.Business.AcademicSession;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.AcademicSettingPersistance
{
    public class AcademicSessionMap : EntityTypeConfiguration<AcademicSession>
    {
        public AcademicSessionMap()
        {
            Ignore(o => o.EntityId);
            HasKey(o => o.SessionId);
            Property(o => o.Session).HasMaxLength(20).IsOptional();
            Property(o => o.SchoolCode).HasMaxLength(20).IsOptional();
        }
    }
}
