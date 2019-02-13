using School.Business.Parents;
using School.Client.Business.Guardian;
using School.Data.Contracts.ParentsContracts;
using System;
using System.Collections.Generic;

namespace School.Data.ParentsRepository
{
    class FatherRepository : DataRepositoryBaseString<Father, ClientFather>, IFatherRepository
    {
        protected override Father AddEntity(SchoolContext entityContext, Father entity)
        {
            throw new NotImplementedException();
        }

        protected override bool DeleteEntity(SchoolContext entityContext, string id)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<ClientFather> GetEntities(SchoolContext entityContext)
        {
            throw new NotImplementedException();
        }

        protected override ClientFather GetEntity(SchoolContext entityContext, Father entity)
        {
            throw new NotImplementedException();
        }

        protected override ClientFather GetEntity(SchoolContext entityContext, string id)
        {
            throw new NotImplementedException();
        }

        protected override Father UpdateEntity(SchoolContext entityContext, Father entity)
        {
            throw new NotImplementedException();
        }
    }
}
