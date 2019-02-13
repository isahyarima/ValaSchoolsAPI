using Core.Common.Contracts;
using Core.Common.Entity;
using Core.Common.SchoolCode.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Business.Parents
{
    public class Father : CommonFields, IIdentifiableEntityString, ISchoolCode
    {
        public string FatherId { get; set; }
        public string StudentId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Occupation { get; set; }
        public string Address { get; set; }
        public string EntityId { get { return FatherId; } set { FatherId = value; } }
        public string SchoolCode { get { return FatherId; } set { FatherId = value; } }

    }
}
