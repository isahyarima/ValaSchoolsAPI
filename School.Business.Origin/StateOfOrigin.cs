using Core.Common.Contracts;
using Core.Common.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Business.Origin
{
    public class StateOfOrigin : CommonFields, IIdentifiableEntity
    {
        public int StateId { get; set; }
        public string StateName { get; set; }
        public int CountryId { get; set; }
        public int EntityId { get { return StateId; } set { StateId = value; } }
    }
}
