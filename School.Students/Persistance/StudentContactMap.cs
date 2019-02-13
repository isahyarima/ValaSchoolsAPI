using School.Students.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Students.Persistance
{
    public class StudentContactMap : EntityTypeConfiguration<StudentContact>
    {
        public StudentContactMap()
        {
            
            Property(o => o.Email)
                .HasMaxLength(100);
            Property(o => o.HomeAddress)
                .HasMaxLength(500);
            Property(o => o.PhoneNumber)
                .HasMaxLength(20);
            Property(o => o.StudentContactId)
                .IsRequired();
        }
    }
}
