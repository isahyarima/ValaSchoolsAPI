
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace School.Client.Business.AcademicSetting
{
    public class ClientAcademicSession 
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
