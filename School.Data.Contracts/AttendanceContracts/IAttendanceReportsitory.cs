using Core.Common.Contracts;
using School.Business.Attendance;
using School.Client.Business.StudentsAttendance;

namespace School.Data.Contracts.AttendanceContracts
{
    public interface IAttendanceRepository : IDataRepository<Attendance, ClientAttendance>
    {
    }
}
