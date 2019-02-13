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
   public class EmployeeOlevel : CommonFields,IIdentifiableEntityString, ISchoolCode
    {
        public int EmployeeOlevelId { get; set; }
        public string SchoolName { get; set; }
        public string SchoolAddress { get; set; }
        public string ExamNumber { get; set; }
        public string ExamYear { get; set; }
        public string ExamBatch { get; set; }
        public string Subject { get; set; }
        public string Grade { get; set; }

        public string EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public string EntityId { get { return EmployeeId; } set { EmployeeId = value; } }
        public string SchoolCode { get { return SchoolCode; } set { SchoolCode = value; } }
    }
}
