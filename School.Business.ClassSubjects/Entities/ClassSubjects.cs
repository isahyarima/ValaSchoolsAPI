using Core.Common.Contracts;
using Core.Common.Entity;
using Core.Common.SchoolCode.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Business.ClassSubjects.Entities
{
   public  class ClassSubjects : CommonFields, IIdentifiableEntity
    {
        public int ClassSubjectsId { get; set; }
        public string ClassId { get; set; }
        public string SectionId { get; set; }
        public string SubjectsId { get; set; }
        public string DateCreated { get; set; }
        public int EntityId { get { return ClassSubjectsId; } set { ClassSubjectsId = value; } }
        public string SchoolCode { get; set; }
    }
}
