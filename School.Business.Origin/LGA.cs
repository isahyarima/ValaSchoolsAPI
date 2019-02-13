using Core.Common.Contracts;
using Core.Common.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Business.Origin
{
   public class LGA : CommonFields, IIdentifiableEntity
    {
        public int LgaId { get; set; }
        public string LgaName { get; set; }
        public int StateId { get; set; }
        public int EntityId { get { return LgaId; } set { LgaId = value; } }
    }
}
