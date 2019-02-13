
using School.Business.Passport;
using School.Client.Business.Passport;
using School.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data
{
  public abstract  class RegistrationPassportRepository : DataRepositoryBaseString<RegistrationPassport, ClientRegistrationPassport>, IRegistrationPassportRepository
    {
       
    }
}
