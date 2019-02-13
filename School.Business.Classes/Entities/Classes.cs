using Core.Common.Contracts;
using Core.Common.Entity;
using Core.Common.SchoolCode.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Business.Classes
{
    public class Classes : CommonFields, IIdentifiableEntity
    {
        public int ClassId { get; set; }
        public string ClassRef { get; set; }
        public string ClassAccronym { get; set; }
        public string ClassName { get; set; }
        public string DateCreated { get; set; }
        public int EntityId
        {
            get { return ClassId; }
            set { ClassId = value; }
        }
        public string SchoolCode { get; set; }
    }
}
