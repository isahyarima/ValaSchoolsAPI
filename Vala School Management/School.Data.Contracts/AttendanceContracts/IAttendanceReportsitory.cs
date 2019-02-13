using Core.Common.Contracts;
using School.Business.Attendance;
using School.Client.Business.Attendancee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Contracts.AttendanceContracts
{
   public interface IAttendanceRepository : IDataRepository<Attendance, ClientAttendance>
    {
    }
}
