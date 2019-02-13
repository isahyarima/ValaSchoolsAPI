using School.Business.Classes.Entities;
using School.Client.Business.SchoolClasses;
using School.Data.Contracts.SectionContracts;
using System;
using System.Collections.Generic;

namespace School.Data.ClassesRepository
{
    public class SectionReppository : DataRepositoryBase<Section, ClientSection>, ISectionRepository
    {
        protected override Section AddEntity(SchoolContext entityContext, Section entity)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<ClientSection> GetEntities(SchoolContext entityContext)
        {
            throw new NotImplementedException();
        }

        protected override ClientSection GetEntity(SchoolContext entityContext, Section entity)
        {
            throw new NotImplementedException();
        }

        protected override ClientSection GetEntity(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override bool Remove(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override Section UpdateEntity(SchoolContext entityContext, Section entity)
        {
            throw new NotImplementedException();
        }
    }
}
