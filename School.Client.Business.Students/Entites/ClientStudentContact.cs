﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Client.Business.Students
{
    public class ClientStudentContact
    {
        public int StudentContactId { get; set; }
        public string Email { get; set; }
        public string HomeAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string StudentId { get; set; }
        public string SchoolCode { get ;  set; } 
    }
}
