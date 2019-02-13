using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Business.AcademicSession;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.AcademicSettingPersistance
{
    public class AcademicSessionMap : IEntityTypeConfiguration<AcademicSession>
    {
        public void Configure(EntityTypeBuilder<AcademicSession> builder)
        {
            builder.Ignore(o => o.EntityId);
            builder.HasKey(o => o.SessionId);
            builder.Property(o => o.Session).HasMaxLength(20);
        }
    }
}
