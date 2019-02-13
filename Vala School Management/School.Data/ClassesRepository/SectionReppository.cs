using School.Business.Classes.Entities;
using School.Client.Business.Classes;
using School.Data.Contracts.SectionContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        protected override Section GetEntity(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override Section Remove(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override Section UpdateEntity(SchoolContext entityContext, Section entity)
        {
            throw new NotImplementedException();
        }
    }
}
