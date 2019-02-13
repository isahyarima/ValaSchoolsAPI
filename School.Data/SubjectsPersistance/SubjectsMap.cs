using School.Business.Subjects;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.SubjectsPersistance
{
    class SubjectsMap : EntityTypeConfiguration<Subjects>
    {
        public SubjectsMap()
        {
            Ignore(o => o.EntityId);
            Property(o => o.SchoolCode).HasMaxLength(20).IsOptional();
            Property(o => o.SubjectAccronym).HasMaxLength(10).IsOptional();
            Property(o => o.SubjectName).HasMaxLength(500).IsOptional();
            HasKey(o => o.SubjectsId);
        }
    }
}
