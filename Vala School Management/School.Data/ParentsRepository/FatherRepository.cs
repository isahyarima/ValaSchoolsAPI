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
    class FatherRepository : DataRepositoryBaseString<Father, ClientFather>, IFatherRepository
    {
        protected override Father AddEntity(SchoolContext entityContext, Father entity)
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

        protected override Father GetEntity(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override Father UpdateEntity(SchoolContext entityContext, Father entity)
        {
            throw new NotImplementedException();
        }
    }
}
