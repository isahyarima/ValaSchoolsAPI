
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
    public class RegistrationPassportRepository : DataRepositoryBaseString<RegistrationPassport, ClientRegistrationPassport> , IRegistrationPassportRepository
    {
        protected override RegistrationPassport AddEntity(SchoolContext entityContext, RegistrationPassport entity)
        {
            throw new NotImplementedException();
        }

        protected override bool DeleteEntity(SchoolContext entityContext, string id)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<ClientRegistrationPassport> GetEntities(SchoolContext entityContext)
        {
            throw new NotImplementedException();
        }

        protected override ClientRegistrationPassport GetEntity(SchoolContext entityContext, RegistrationPassport entity)
        {
            throw new NotImplementedException();
        }

        protected override ClientRegistrationPassport GetEntity(SchoolContext entityContext, string id)
        {
            throw new NotImplementedException();
        }

        protected override RegistrationPassport UpdateEntity(SchoolContext entityContext, RegistrationPassport entity)
        {
            throw new NotImplementedException();
        }
    }
}
