using Core.Common.Contracts;
using Core.Common.Entity;
using Core.Common.SchoolCode.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Business.Employees
{
   public class EmployeeContact : CommonFields, IIdentifiableEntityString, ISchoolCode
    {
        public int EmployeeContactId { get; set; }
        public string Email { get; set; }
        public string HomeAddress { get; set; }
        public string PhoneNumber { get; set; }

        public string EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public string EntityId { get { return EmployeeId; } set { EmployeeId = value; } }
        public string SchoolCode { get { return SchoolCode; } set { SchoolCode = value; } }
    }
}
