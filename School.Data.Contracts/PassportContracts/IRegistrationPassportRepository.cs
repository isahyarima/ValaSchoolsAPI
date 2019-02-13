
using Core.Common.Contracts;
using School.Business.Passport;
using School.Client.Business.Passport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Contracts
{
   public interface IRegistrationPassportRepository : IDataRepositoryString<RegistrationPassport, ClientRegistrationPassport>
    {
    }
}
