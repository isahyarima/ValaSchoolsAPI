
using Core.Common.Entity;

namespace School.Client.Business.AcademicSettings
{
    public class ClientGradeSetting : CommonFields
    {
        public int GradeId { get; set; }
        public string ClassesId { get; set; }
        public string SubjectsId { get; set; }
        public int MinScore { get; set; }
        public int MaxScore { get; set; }
        public string Grade { get; set; }
        public string GradeDescription { get; set; }
        public string Remark { get; set; }


    }
}
