using Core.Common.Contracts;
using Core.Common.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Business.TimeTable
{
    public class TimeTable : CommonFields, IIdentifiableEntity
    {
        public int TimeTableId { get; set; }
        public string ClassId { get; set; }
        public string SectionId { get; set; }
        public string SubjectsId { get; set; }
        public string DateCreated { get; set; }
        public string Monday { get; set; }
        public string Tuesday { get; set; }
        public string Wednesday { get; set; }
        public string Thursday { get; set; }
        public string Friday { get; set; }
        public string Saturday { get; set; }
        public string Sunday { get; set; }
        public int EntityId { get { return TimeTableId; } set { TimeTableId = value; } }
    }
}
