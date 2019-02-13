using Core.Common.Contracts;
using Core.Common.Entity;
using Core.Common.SchoolCode.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Business.Session
{
    public class AssessmentSetting : CommonFields, IIdentifiableEntity, ISchoolCode
    {
        public int AssessmentSettingId { get; set; }
        public string AssessmentType { get; set; }
        public int Scores { get; set; }
        public string Session { get; set; }
        public string SectionId { get; set; }
        public string ClassId { get; set; }
        public string SchoolCode { get; set; }
        public int EntityId { get { return AssessmentSettingId; } set { AssessmentSettingId = value; } }
    }
}
