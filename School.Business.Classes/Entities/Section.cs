using Core.Common.Contracts;
using Core.Common.Entity;
using Core.Common.SchoolCode.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Business.Classes.Entities
{
   public class Section : CommonFields, IIdentifiableEntity
    {
        public int SectionId { get; set; }
        public string ClassId { get; set; }
        public string SectionName { get; set; }
        public int EntityId
        {
            get { return SectionId; }
            set { SectionId = value; }
        }
        public string SchoolCode { get; set; }
    }
}
