using School.Business.ClassEnrolment;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.ClassEnrolmentPersistance
{
    class ClassEnrolmentMap : EntityTypeConfiguration<ClassEnrolment>
    {
        public ClassEnrolmentMap()
        {
            Ignore(o => o.EntityId);
            Property(o => o.ClassEnrolmentId);
            HasKey(o => o.ClassEnrolmentId);
            Property(o => o.ClassId).HasMaxLength(20).IsOptional() ;
            Property(o => o.DateModified).HasMaxLength(50).IsOptional();
            Property(o => o.DateRegistered).HasMaxLength(50).IsOptional();
            Property(o => o.RegistrationNumber).HasMaxLength(20).IsOptional();
            Property(o => o.SchoolCode).HasMaxLength(20).IsOptional();
            Property(o => o.StudentId).HasMaxLength(20).IsOptional();
        }
    }
}
