using School.Business.Parents;
using School.Client.Business.Parents;
using School.Data.Contracts.ParentsContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.ParentsRepository
{
    class MotherRepository : DataRepositoryBaseString<Mother, ClientMother>, IMotherRepository
    {
        protected override Mother AddEntity(SchoolContext entityContext, Mother entity)
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

        protected override Mother GetEntity(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override Mother UpdateEntity(SchoolContext entityContext, Mother entity)
        {
            throw new NotImplementedException();
        }
    }
}
