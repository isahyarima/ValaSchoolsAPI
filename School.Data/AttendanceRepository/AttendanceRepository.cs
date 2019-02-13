using School.Business.Attendance;
using School.Client.Business.StudentsAttendance;
using School.Data.Contracts.AttendanceContracts;
using System;
using System.Collections.Generic;

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

        protected override ClientAttendance GetEntity(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override bool Remove(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override Attendance UpdateEntity(SchoolContext entityContext, Attendance entity)
        {
            throw new NotImplementedException();
        }
    }
}
