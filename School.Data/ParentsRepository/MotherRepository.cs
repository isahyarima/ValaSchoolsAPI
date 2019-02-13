using School.Business.Parents;
using School.Client.Business.Guardian;
using School.Data.Contracts.ParentsContracts;
using System;
using System.Collections.Generic;

namespace School.Data.ParentsRepository
{
    class MotherRepository : DataRepositoryBaseString<Mother, ClientMother>, IMotherRepository
    {
        protected override Mother AddEntity(SchoolContext entityContext, Mother entity)
        {
            throw new NotImplementedException();
        }

        protected override bool DeleteEntity(SchoolContext entityContext, string id)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<ClientMother> GetEntities(SchoolContext entityContext)
        {
            throw new NotImplementedException();
        }

        protected override ClientMother GetEntity(SchoolContext entityContext, Mother entity)
        {
            throw new NotImplementedException();
        }

        protected override ClientMother GetEntity(SchoolContext entityContext, string id)
        {
            throw new NotImplementedException();
        }

        protected override Mother UpdateEntity(SchoolContext entityContext, Mother entity)
        {
            throw new NotImplementedException();
        }
    }
}
