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
    public class CountryRepository : DataRepositoryBase<Country, ClientCountry>, ICountryRepository
    {
        protected override Country AddEntity(SchoolContext entityContext, Country entity)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<ClientCountry> GetEntities(SchoolContext entityContext)
        {
            throw new NotImplementedException();
        }

        protected override ClientCountry GetEntity(SchoolContext entityContext, Country entity)
        {
            throw new NotImplementedException();
        }

        protected override Country GetEntity(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override Country Remove(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override Country UpdateEntity(SchoolContext entityContext, Country entity)
        {
            throw new NotImplementedException();
        }
    }
}
