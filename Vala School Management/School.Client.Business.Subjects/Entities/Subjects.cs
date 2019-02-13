
using Core.Common.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Client.Business.Subjects
{
  public  class ClientSubjects : CommonFields
    {
        public int SubjectsId { get; set; }
        public string SubjectAccronym { get; set; }
        public string SubjectName { get; set; }
    }
}
