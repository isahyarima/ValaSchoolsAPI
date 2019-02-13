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
    public class StateOfOriginRepository : DataRepositoryBase<StateOfOrigin, ClientStateOfOrigin>, IStateOfOriginRepository
    {
        protected override StateOfOrigin AddEntity(SchoolContext entityContext, StateOfOrigin entity)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<ClientStateOfOrigin> GetEntities(SchoolContext entityContext)
        {
            throw new NotImplementedException();
        }

        protected override ClientStateOfOrigin GetEntity(SchoolContext entityContext, StateOfOrigin entity)
        {
            throw new NotImplementedException();
        }

        protected override StateOfOrigin GetEntity(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override StateOfOrigin Remove(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override StateOfOrigin UpdateEntity(SchoolContext entityContext, StateOfOrigin entity)
        {
            throw new NotImplementedException();
        }
    }
}
