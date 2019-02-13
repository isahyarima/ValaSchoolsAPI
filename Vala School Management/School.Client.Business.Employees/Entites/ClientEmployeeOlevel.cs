
using Core.Common.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Client.Business.Employees
{
   public class ClientEmployeeOlevel : CommonFields
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
    }
}
