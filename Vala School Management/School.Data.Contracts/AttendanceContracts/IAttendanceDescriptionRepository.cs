using Core.Common.Contracts;
using School.Business.Attendance;
using School.Client.Business.Attendance;

namespace School.Data.Contracts.AttendanceContracts
{
    public interface IAttendanceDescriptionRepository : IDataRepository<AttendanceDescription, ClientAttendanceDescription>
    {
    }
}
