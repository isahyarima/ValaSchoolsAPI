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
    public class Attendance : CommonFields,  IIdentifiableEntity
    {
        public int AttendanceId { get; set; }
        public string SectionId { get; set; }
        public string ClassId { get; set; }
        public string Session { get; set; }
        public string AttendanceDate { get; set; }
        public string Month { get; set; }
        public string Day { get; set; }
        public string StudentId { get; set; }
        public string RegistrationNumber { get; set; }
        public string AttendanceStatus { get; set; }
        public string AttendanceDesc { get; set; }
        public string Remark { get; set; }
        public int EntityId { get { return AttendanceId; } set { AttendanceId = value; } }
        public string SchoolCode { get; set; }
    }
}
