using Core.Common.Contracts;
using Core.Common.Entity;
using Core.Common.SchoolCode.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Business.Students
{
    public class StudentContact : CommonFields, IIdentifiableEntityString, ISchoolCode
    {
        public int StudentContactId { get; set; }
        public string Email { get; set; }
        public string HomeAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string StudentId { get; set; }
        public virtual Student Student { get; set; }
        public string EntityId {
            get { return StudentId; }
            set { StudentId = value; } }
        public string SchoolCode { get { return SchoolCode; } set { SchoolCode = value; } }
    }
}
