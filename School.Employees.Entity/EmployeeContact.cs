using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Employees.Entity
{
    class EmployeeContact
    {
        public int EmployeeContactId { get; set; }
        public string StateOfOrigin { get; set; }
        public string LocalGovt { get; set; }
        public string Email { get; set; }
        public string HomeAddress { get; set; }
        public string Religion { get; set; }
        public string NativeLaguage { get; set; }
        public string PhoneNumber { get; set; }
    }
}
