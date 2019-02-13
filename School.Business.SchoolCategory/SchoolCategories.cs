using Core.Common.Contracts;
using Core.Common.SchoolCode.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Business.SchoolCategories
{
    public class SchoolCategories : IIdentifiableEntityString, ISchoolCode
    {
        public string SchoolCategoryId { get; set; }
        public string SchoolCategoryName { get; set; }
        public string EntityId { get { return SchoolCategoryId; } set { SchoolCategoryId = value; }  }
        public string SchoolCode { get { return SchoolCategoryId; } set { SchoolCategoryId = value; } }
    }
}
