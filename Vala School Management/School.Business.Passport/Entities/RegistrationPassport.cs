using Core.Common.Contracts;
using Core.Common.SchoolCode.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Business.Passport
{
   public class RegistrationPassport : IIdentifiableEntityString
    {
        public int RegistrationPassportsId { get; set; }
        public string PersonId { get; set; }
        public Byte? ImageBinary { get; set; }
        public string ImagePath { get; set; }
        public string ImageName { get; set; }
        public string ImageExtention { get; set; }
        public string ImageSize { get; set; }
        public string ImageStatus { get; set; }
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
        public string EntityId { get { return PersonId; } set { PersonId = value; } }
    }
}
