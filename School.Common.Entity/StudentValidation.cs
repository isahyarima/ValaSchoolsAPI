using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Common.Entity
{
    public class StudentValidation
    {
        public int ValidationId { get; set; }
        public DateTime DataCreated { get; set; }
        public string CreatedBy { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime DateDeleted { get; set; }
        public string DeletedBy { get; set; }
        public bool IsModified { get; set; }
        public DateTime DateModified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
