using Core.Common.Entity;

namespace School.Client.Business.Scores
{
    public class ClientScores : CommonFields
    {
        public int ScoresId { get; set; }
        public string SubjectsId { get; set; }
        public string SubjectAccronym { get; set; }
        public double FirstTest { get; set; }
        public double SecondTest { get; set; }
        public double ThirdTest { get; set; }
        public double TotalTest { get; set; }
        public double FirstAssignment { get; set; }
        public double SecondAssignment { get; set; }
        public double ThirdAssignment { get; set; }
        public double TotalAssignment { get; set; }
        public double FirstHomeWork { get; set; }
        public double SecondHomeWork { get; set; }
        public double ThirdHomeWork { get; set; }
        public double TotalHomeWork { get; set; }
        public double FirstActivity { get; set; }
        public double SecondActivity { get; set; }
        public double ThirdActivity { get; set; }
        public double TotalActivities { get; set; }
        public string StudentId { get; set; }
        public string RegistrationNumber { get; set; }
        public string Session { get; set; }
        public string SectionId { get; set; }
        public string ClassId { get; set; }
    }
}
