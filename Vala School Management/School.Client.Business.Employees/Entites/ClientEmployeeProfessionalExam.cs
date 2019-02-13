
using Core.Common.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Client.Business.Employees
{
   public class ClientEmployeeProfessionalExam : CommonFields
    {
        public int EmployeeProfessionalExamId { get; set; }
        public string ExamBody { get; set; }
        public string ExamDate { get; set; }
        public string CertificationName { get; set; }
        public string EmployeeId { get; set; }
    }
}
