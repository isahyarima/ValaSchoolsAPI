
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace School.Client.Business.AcademicSetting
{
    public class ClientGradeSetting 
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
