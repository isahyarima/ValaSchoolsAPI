


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
    public class Student : CommonFields, IIdentifiableEntityString ,ISchoolCode
    {
        
        public string StudentId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string StateOfOrigin { get; set; }
        public string LocalGovt { get; set; }
        public string DateOfBirth { get; set; }
        public string Religion { get; set; }
        public string NativeLaguage { get; set; }
        public string EntityId
        {
            get { return StudentId; }
            set { StudentId = value; }
        }

        public string SchoolCode
        {
            get { return StudentId; }
            set { StudentId = value; }
        }
    }
}
