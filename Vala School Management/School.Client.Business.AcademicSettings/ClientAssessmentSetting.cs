
using Core.Common.Entity;

namespace School.Client.Business.AcademicSettings
{
    public class ClientAssessmentSetting : CommonFields
    {
        public int AssessmentSettingId { get; set; }
        public string AssessmentType { get; set; }
        public int Scores { get; set; }
        public string Session { get; set; }
        public string SectionId { get; set; }
        public string ClassId { get; set; }

    }
}
