using School.Business.Attendance;
using School.Client.Business.Attendance;
using School.Data.Contracts.AttendanceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.AttendanceRepository
{
    public class AttendanceDescriptionRepository : DataRepositoryBase<AttendanceDescription, ClientAttendanceDescription>, IAttendanceDescriptionRepository
    {
        protected override AttendanceDescription AddEntity(SchoolContext entityContext, AttendanceDescription entity)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<ClientAttendanceDescription> GetEntities(SchoolContext entityContext)
        {
            throw new NotImplementedException();
        }

        protected override ClientAttendanceDescription GetEntity(SchoolContext entityContext, AttendanceDescription entity)
        {
            throw new NotImplementedException();
        }

        protected override AttendanceDescription GetEntity(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override AttendanceDescription Remove(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override AttendanceDescription UpdateEntity(SchoolContext entityContext, AttendanceDescription entity)
        {
            throw new NotImplementedException();
        }
    }
}
