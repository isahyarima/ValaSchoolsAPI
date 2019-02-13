using School.Business.Origin;
using School.Client.Business.Location;
using School.Data.Contracts.OriginContracts;
using System;
using System.Collections.Generic;

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

        protected override ClientCountry GetEntity(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override bool Remove(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override Country UpdateEntity(SchoolContext entityContext, Country entity)
        {
            throw new NotImplementedException();
        }
    }
}
