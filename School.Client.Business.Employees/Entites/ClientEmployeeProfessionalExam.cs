
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Client.Business.Employees
{
   public class ClientEmployeeProfessionalExam 
    {
        public int EmployeeProfessionalExamId { get; set; }
        public string ExamBody { get; set; }
        public string ExamDate { get; set; }
        public string CertificationName { get; set; }

        public string EmployeeId { get; set; }
        
        public string EntityId { get {return EmployeeId; } set { EmployeeId = value; } }
        public string SchoolCode { get { return SchoolCode; } set { SchoolCode = value; } }
    }
}
