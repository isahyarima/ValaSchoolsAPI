using School.Business.ClassSubjects.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.ClassSubjectsPersistance
{
   public class ClassSubjectMap : EntityTypeConfiguration<ClassSubjects>
    {
        public ClassSubjectMap()
        {
            Property(o => o.ClassId).HasMaxLength(20).IsOptional(); ;
            HasKey(O => O.ClassSubjectsId);
            Property(O => O.ClassSubjectsId);
            Property(o => o.DateCreated).HasMaxLength(50).IsOptional();
            Ignore(o => o.EntityId);
            Property(o => o.SchoolCode).HasMaxLength(20).IsOptional();
            Property(o => o.SubjectsId).HasMaxLength(20).IsOptional();
        }
    }
}
