using Core.Common.Contracts;
using Core.Common.SchoolCode.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Business.GradeSetting
{
    public class GradeSetting : IIdentifiableEntity
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

    }
}
