using School.Business.School;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.SchoolPersistance
{
    public class SchoolInformationMap : EntityTypeConfiguration<SchoolInformation>
    {
        public SchoolInformationMap()
        {
            //Ignore(o => o.EntityId);
            //Property(o => o.SchoolCode).HasMaxLength(20).IsRequired();
            //Property(o => o.SchoolName).HasMaxLength(200).IsRequired();
            //HasKey(o => o.SchoolId);
        }
    }
}
