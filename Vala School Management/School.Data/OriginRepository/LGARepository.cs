using School.Business.Origin;
using School.Client.Business.Origin;
using School.Data.Contracts.OriginContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.OriginRepository
{
    class LGARepository : DataRepositoryBase<LGA, ClientLGA>, ILGARepository
    {
        protected override LGA AddEntity(SchoolContext entityContext, LGA entity)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<ClientLGA> GetEntities(SchoolContext entityContext)
        {
            throw new NotImplementedException();
        }

        protected override ClientLGA GetEntity(SchoolContext entityContext, LGA entity)
        {
            throw new NotImplementedException();
        }

        protected override LGA GetEntity(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override LGA Remove(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override LGA UpdateEntity(SchoolContext entityContext, LGA entity)
        {
            throw new NotImplementedException();
        }
    }
}
