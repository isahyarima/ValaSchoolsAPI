namespace School.Client.Business.ClassEnrolments
{
    public class ClientClassEnrolment 
    {
        public int ClassEnrolmentId { get; set; }
        public string ClassId { get; set; }
        public string StudentId { get; set; }
        public string RegistrationNumber { get; set; }
        public string DateRegistered { get; set; }
        public string DateModified { get; set; }
        public bool IsPromoted { get; set; }
      
    }
}
