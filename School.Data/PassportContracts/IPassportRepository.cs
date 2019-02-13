using School.Common.Contracts;
using School.Passport.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.PassportContracts
{
   public interface IPassportRepository : IDataRepository<RegistrationPassport>
    {
    }
}
