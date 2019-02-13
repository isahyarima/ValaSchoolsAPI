using System.Collections.Generic;
using School.Business.Origin;
using School.Client.Business.Location;
using School.Data.Contracts.OriginContracts;

namespace School.Data.OriginRepository
{
    public class StateOfOriginRepository : DataRepositoryBase<StateOfOrigin, ClientStateOfOrigin>, IStateOfOriginRepository
    {
        protected override StateOfOrigin AddEntity(SchoolContext entityContext, StateOfOrigin entity)
        {
            throw new System.NotImplementedException();
        }

        protected override IEnumerable<ClientStateOfOrigin> GetEntities(SchoolContext entityContext)
        {
            throw new System.NotImplementedException();
        }

        protected override ClientStateOfOrigin GetEntity(SchoolContext entityContext, StateOfOrigin entity)
        {
            throw new System.NotImplementedException();
        }

        protected override ClientStateOfOrigin GetEntity(SchoolContext entityContext, int id)
        {
            throw new System.NotImplementedException();
        }

        protected override bool Remove(SchoolContext entityContext, int id)
        {
            throw new System.NotImplementedException();
        }

        protected override StateOfOrigin UpdateEntity(SchoolContext entityContext, StateOfOrigin entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
