using Core.Common.Contracts;
using Core.Common.Entity;
using Core.Common.SchoolCode.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Business.AcademicSession
{
    public class AcademicSession : CommonFields, IIdentifiableEntityString
    {
        public int SessionId { get; set; }
        public string Session { get; set; }
        public string EntityId
        {
            get { return Session; }
            set { Session = value; }
        }

        public string SchoolCode
        { get; set; }
    }
}
