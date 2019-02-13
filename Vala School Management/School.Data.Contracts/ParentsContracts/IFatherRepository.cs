using Core.Common.Contracts;
using School.Business.Parents;
using School.Client.Business.Parents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Contracts.ParentsContracts
{
   public interface IFatherRepository : IDataRepositoryString<Father, ClientFather>
    {
    }
}
