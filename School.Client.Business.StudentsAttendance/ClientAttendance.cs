namespace School.Client.Business.StudentsAttendance { 
    public class ClientAttendance 
    {
        public int AttendanceId { get; set; }
        public string SectionId { get; set; }
        public string ClassId { get; set; }
        public string Session { get; set; }
        public string AttendanceDate { get; set; }
        public string Month { get; set; }
        public string Day { get; set; }
        public string StudentId { get; set; }
        public string RegistrationNumber { get; set; }
        public string AttendanceStatus { get; set; }
        public string AttendanceDesc { get; set; }
        public string Remark { get; set; }
    }
}
