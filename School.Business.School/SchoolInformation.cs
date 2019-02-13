using Core.Common.Contracts;
using Core.Common.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Business.School
{
    public class SchoolInformation : CommonFields, IIdentifiableEntity
    {
        public int schoolId { get; set; }
        public string schoolCode { get; set; }
        public object SchoolCode { get; set; }
        public string schoolName { get; set; }
        public int EntityId { get { return schoolId; } set { schoolId = value; } }
    }
}
