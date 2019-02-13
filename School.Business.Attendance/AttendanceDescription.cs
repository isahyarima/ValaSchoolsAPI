using Core.Common.Contracts;
using Core.Common.Entity;
using Core.Common.SchoolCode.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Business.Attendance
{
    public class AttendanceDescription : CommonFields, IIdentifiableEntity
    {
        public int AttendanceDescId { get; set; }
        public string AttendanceDesc { get; set; }
        public int EntityId { get { return AttendanceDescId; } set { AttendanceDescId = value; } }
        public string SchoolCode { get; set; }
    }
}
