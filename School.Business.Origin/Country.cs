using Core.Common.Contracts;
using Core.Common.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Business.Origin
{
   public class Country : CommonFields, IIdentifiableEntity
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public int EntityId { get { return CountryId; } set { CountryId = value; } }
    }
}
