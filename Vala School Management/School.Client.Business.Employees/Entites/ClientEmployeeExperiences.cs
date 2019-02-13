
using Core.Common.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Client.Business.Employees
{
   public class ClientEmployeeExperiences : CommonFields
    {
        public int EmployeeExperienceId { get; set; }
        public string PositionHeld { get; set; }
        public string EmployerName { get; set; }
        public DateTime EmploymentDate { get; set; }
        public DateTime TerminationDate { get; set; }
        public string Contribution { get; set; }

    }
}
