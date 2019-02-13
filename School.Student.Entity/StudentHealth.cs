using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Student.Entity
{
   public class StudentHealth
    {
        public int HealthId { get; set; }
        public string BloodGroup { get; set; }
        public string EyeStatus { get; set; }
        public string EarStatus { get; set; }
        public string Temperament { get; set; }
        public string PrequestCases { get; set; }

        public virtual Student Student { get; set; }
    }
}
