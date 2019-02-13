using School.Business.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.ClassesPersistance
{
    public class ClassesMap : EntityTypeConfiguration<Classes>
    {
        public ClassesMap()
        {
            Property(o => o.ClassAccronym).HasMaxLength(20).IsOptional();
            HasKey(o => o.ClassId);
            Property(o=>o.ClassId);
            Property(o => o.ClassName).HasMaxLength(500).IsOptional();
            Property(o => o.ClassRef).HasMaxLength(20).IsOptional();
            Property(o => o.DateCreated).HasMaxLength(50).IsOptional();
            Property(o => o.SchoolCode).HasMaxLength(20).IsOptional();
            Ignore(o => o.EntityId);
        }
    }
}
