using School.Business.Attendance;
using School.Client.Business.Attendancee;
using School.Data.Contracts.AttendanceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.AttendanceRepository
{
    public class AttendanceRepository : DataRepositoryBase<Attendance, ClientAttendance>, IAttendanceRepository
    {
        protected override Attendance AddEntity(SchoolContext entityContext, Attendance entity)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<ClientAttendance> GetEntities(SchoolContext entityContext)
        {
            throw new NotImplementedException();
        }

        protected override ClientAttendance GetEntity(SchoolContext entityContext, Attendance entity)
        {
            throw new NotImplementedException();
        }

        protected override Attendance GetEntity(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override Attendance Remove(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override Attendance UpdateEntity(SchoolContext entityContext, Attendance entity)
        {
            throw new NotImplementedException();
        }
    }
}
