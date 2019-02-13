
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Client.Business.Employees
{
   public class ClientEmployee
    {

        public string EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string StateOfOrigin { get; set; }
        public string LocalGovt { get; set; }
        public string DateOfBirth { get; set; }
        public string Religion { get; set; }
        public string NativeLaguage { get; set; }
        public string SchoolCode { get { return SchoolCode; } set { SchoolCode = value; } }
    }
}
