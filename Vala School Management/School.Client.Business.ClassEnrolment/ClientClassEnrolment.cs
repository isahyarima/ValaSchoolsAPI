using Core.Common.Entity;

namespace School.Client.Business.ClassEnrolment
{
    public class ClientClassEnrolment : CommonFields
    {
        public int ClassEnrolmentId { get; set; }
        public string ClassId { get; set; }
        public string StudentId { get; set; }
        public string RegistrationNumber { get; set; }
        public string DateRegistered { get; set; }
        public bool IsPromoted { get; set; }

    }
}
