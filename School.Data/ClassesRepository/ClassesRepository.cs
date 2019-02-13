using School.Business.Classes;
using School.Client.Business.SchoolClasses;
using School.Data.Contracts.ClassesContracts;
using System;
using System.Collections.Generic;

namespace School.Data.ClassesRepository
{
    public class ClassesRepository : DataRepositoryBase<Classes, ClientClasses>, IClassesRepository
    {
        protected override Classes AddEntity(SchoolContext entityContext, Classes entity)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<ClientClasses> GetEntities(SchoolContext entityContext)
        {
            throw new NotImplementedException();
        }

        protected override ClientClasses GetEntity(SchoolContext entityContext, Classes entity)
        {
            throw new NotImplementedException();
        }

        protected override ClientClasses GetEntity(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override bool Remove(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override Classes UpdateEntity(SchoolContext entityContext, Classes entity)
        {
            throw new NotImplementedException();
        }
    }
}
