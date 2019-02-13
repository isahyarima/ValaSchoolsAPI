using Core.Common.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Client.Business.School
{
    public class ClientSchoolInformation : CommonFields
    {
        public string SchoolCode { get; set; }
        public string SchoolName { get; set; }
        public string SchoolAddress { get; set; }
        public string ContactNumber { get; set; }
        public byte[] logo { get; set; }

    }
}
