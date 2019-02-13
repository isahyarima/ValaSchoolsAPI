using School.Students.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Students.Persistance
{
   public class StudentTableExtentionMap : EntityTypeConfiguration<StudentTableExtention>
    {
        public StudentTableExtentionMap()
        {
            Property(o => o.ApprovedBy)
                            .HasMaxLength(200);
            Property(o => o.ApprovedFrom)
                         .HasMaxLength(200);
            Property(o => o.CreatedBy)
                         .HasMaxLength(200);
            Property(o => o.CreatedFrom)
             .HasMaxLength(200);
            Property(o => o.DeletedBy)
                         .HasMaxLength(200);
            Property(o => o.ModifiedBy)
             .HasMaxLength(200);
            Property(o => o.ModifiedFrom)
             .HasMaxLength(200);
            Property(o => o.CreatedBy)
             .HasMaxLength(200);
            Property(o => o.Status)
             .HasMaxLength(20);
            Property(o => o.SystemIP)
             .HasMaxLength(20);
           
        }
    }
}
