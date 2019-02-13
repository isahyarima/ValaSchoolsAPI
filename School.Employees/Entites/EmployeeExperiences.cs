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
   public class EmployeeExperiences : CommonFields, IIdentifiableEntityString, ISchoolCode
    {
        public int EmployeeExperienceId { get; set; }
        public string PositionHeld { get; set; }
        public string EmployerName { get; set; }
        public DateTime EmploymentDate { get; set; }
        public DateTime TerminationDate { get; set; }
        public string Contribution { get; set; }

        public string EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public string EntityId { get {return EmployeeId; } set { EmployeeId = value; } }
        public string SchoolCode { get { return SchoolCode; } set { SchoolCode = value; } }
    }
}
