using Core.Common.Entity;

namespace School.Client.Business.ClassSubjects
{
    public  class ClientClassSubjects : CommonFields
    {
        public int ClassSubjectsId { get; set; }
        public string ClassId { get; set; }
        public string SectionId { get; set; }
        public string SubjectsId { get; set; }
       
    }
}
