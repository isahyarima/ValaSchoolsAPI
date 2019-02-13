﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Student.Entity
{
    class StudentGuardian 
    {
        public int GuardianId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string DateOfBirth { get; set; }
        public string StateOfOrigin { get; set; }
        public string LocalGovt { get; set; }
        public string Email { get; set; }
        public string HomeAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string OfficeAddress { get; set; }
        public string OfficeNumber { get; set; }
        public string Relationship { get; set; }

        public virtual Student Student { get; set; }
    }
}