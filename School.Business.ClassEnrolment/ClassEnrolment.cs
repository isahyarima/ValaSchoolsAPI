using Core.Common.Contracts;
using Core.Common.Entity;
using Core.Common.SchoolCode.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Business.ClassEnrolment
{
    public class ClassEnrolment : CommonFields, IIdentifiableEntity
    {
        public int ClassEnrolmentId { get; set; }
        public string ClassId { get; set; }
        public string StudentId { get; set; }
        public string RegistrationNumber { get; set; }
        public string DateRegistered { get; set; }
        public string DateModified { get; set; }
        public bool IsPromoted { get; set; }
        public int EntityId
        {
            get { return ClassEnrolmentId; }
            set { ClassEnrolmentId = value; }
        }

        public string SchoolCode
        { get; set; }
    }
}
