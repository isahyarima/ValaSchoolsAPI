
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace School.Client.Business.AcademicSetting
{
    public class ClientAssessmentSetting 
    {
        public int AssessmentSettingId { get; set; }
        public string AssessmentType { get; set; }
        public int Scores { get; set; }
        public string Session { get; set; }
        public string SectionId { get; set; }
        public string ClassId { get; set; }
        public string SchoolCode { get; set; }
     
    }
}
