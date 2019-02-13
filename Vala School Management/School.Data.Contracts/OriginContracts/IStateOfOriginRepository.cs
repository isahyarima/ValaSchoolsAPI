using Core.Common.Contracts;
using School.Business.Origin;
using School.Client.Business.Origin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Contracts.OriginContracts
{
   public interface IStateOfOriginRepository : IDataRepository<StateOfOrigin, ClientStateOfOrigin>
    {
    }
}
