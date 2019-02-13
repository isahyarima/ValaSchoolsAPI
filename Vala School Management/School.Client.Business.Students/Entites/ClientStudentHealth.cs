
using Core.Common.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Client.Business.Students
{
    public class ClientStudentHealth : CommonFields
    {
        public int StudentHealthId { get; set; }
        public string BloodGroup { get; set; }
        public string EyeStatus { get; set; }
        public string EarStatus { get; set; }
        public string Temperament { get; set; }
        public string PrequestCases { get; set; }
        public string StudentId { get; set; }

       
    }
}
