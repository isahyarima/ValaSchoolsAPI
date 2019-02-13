
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Client.Business.Employees
{
   public class ClientEmployeeContact
    {
        public int EmployeeContactId { get; set; }
        public string Email { get; set; }
        public string HomeAddress { get; set; }
        public string PhoneNumber { get; set; }

        public string EmployeeId { get; set; }
       
    }
}
