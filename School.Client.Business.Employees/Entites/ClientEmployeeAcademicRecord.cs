﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Client.Business.Employees
{
   public class ClientEmployeeAcademicRecord
    {
        public int EmployeeAcademicRecordId { get; set; }
        public string SchoolName { get; set; }
        public DateTime EnrolmentDate { get; set; }
        public DateTime GraduationDate { get; set; }
        public string CertificateObtained { get; set; }
    }
}
