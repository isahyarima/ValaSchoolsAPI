using Core.Common.Contracts;
using Core.Common.Entity;
using Core.Common.SchoolCode.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Business.Students
{
    public class StudentHealth : CommonFields, IIdentifiableEntityString, ISchoolCode
    {
        public int StudentHealthId { get; set; }
        public string BloodGroup { get; set; }
        public string EyeStatus { get; set; }
        public string EarStatus { get; set; }
        public string Temperament { get; set; }
        public string PrequestCases { get; set; }

        public string StudentId { get; set; }
        public virtual Student Student { get; set; }
        public string EntityId
        {
            get { return StudentId; }
            set { StudentId = value; }
        }
        public string SchoolCode { get { return SchoolCode; } set { SchoolCode = value; } }

       
    }
}
