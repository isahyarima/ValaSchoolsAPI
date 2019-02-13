using Core.Common.SchoolCode.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.SchoolRepository
{
    public  class SchoolReference : ISchoolReference
    {
        public string GetSchoolCode()
        {
            using (var db = new SchoolContext())
            {
                var schoolCode = db.SchoolSet.FirstOrDefault().SchoolCode;
                if (schoolCode!=null)
                {
                    return schoolCode;
                }
                return "'006' Bad Request : No Code Found";
            }
        }
    }
}
