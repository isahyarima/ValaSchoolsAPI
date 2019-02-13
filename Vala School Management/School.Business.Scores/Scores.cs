using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Common.Contracts;
using Core.Common.SchoolCode.Contracts;

namespace School.Business.Scores
{
    public class Scores : IIdentifiableEntity
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
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedFrom { get; set; }
        public bool IsModefied { get; set; }
        public DateTime DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedFrom { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateDeleted { get; set; }
        public string DeletedBy { get; set; }
        public string DeletedFrom { get; set; }
        public bool IsApproved { get; set; }
        public DateTime DateApproved { get; set; }
        public string ApprovedBy { get; set; }
        public string ApprovedFrom { get; set; }
        public string Status { get; set; }
        public string comment { get; set; }
        public int SchoolId { get; set; }
        public int EntityId { get { return ScoresId; } set { ScoresId = value; } }

    }
}
