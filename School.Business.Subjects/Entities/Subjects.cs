using Core.Common.Contracts;
using Core.Common.Entity;
using Core.Common.SchoolCode.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Business.Subjects
{
  public  class Subjects : CommonFields, IIdentifiableEntity
    {
        public int SubjectsId { get; set; }
        public string SubjectAccronym { get; set; }
        public string SubjectName { get; set; }
        public int EntityId { get { return SubjectsId; } set { SubjectsId = value; } }
        public string SchoolCode { get; set; }
    }
}
