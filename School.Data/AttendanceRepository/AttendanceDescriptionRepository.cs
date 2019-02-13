using School.Business.Attendance;
using School.Client.Business.StudentsAttendance;
using School.Data.Contracts.AttendanceContracts;
using System;
using System.Collections.Generic;

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

        protected override ClientAttendanceDescription GetEntity(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override bool Remove(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override AttendanceDescription UpdateEntity(SchoolContext entityContext, AttendanceDescription entity)
        {
            throw new NotImplementedException();
        }
    }
}
