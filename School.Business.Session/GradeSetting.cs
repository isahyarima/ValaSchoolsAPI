using Core.Common.Contracts;
using Core.Common.Entity;
using Core.Common.SchoolCode.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Business.GradeSetting
{
    public class GradeSetting : CommonFields, IIdentifiableEntity
    {
        public int GradeId { get; set; }
        public string ClassesId { get; set; }
        public string SubjectsId { get; set; }
        public int MinScore { get; set; }
        public int MaxScore { get; set; }
        public string Grade { get; set; }
        public string GradeDescription { get; set; }
        public string Remark { get; set; }
        public int EntityId { get { return GradeId; } set { GradeId = value; } }
        public string SchoolCode { get; set; }

    }
}
