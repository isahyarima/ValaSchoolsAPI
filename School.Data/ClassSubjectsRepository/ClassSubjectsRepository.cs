using School.Business.ClassSubjects.Entities;
using School.Client.Business.ClassSubject;
using School.Data.Contracts.ClassSubjectsContracts;
using System;
using System.Collections.Generic;

namespace School.Data.ClassSubjectsRepository
{
    public class ClassSubjectsRepository : DataRepositoryBase<ClassSubjects, ClientClassSubjects>, IClassSubjectsRepository
    {
        protected override ClassSubjects AddEntity(SchoolContext entityContext, ClassSubjects entity)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<ClientClassSubjects> GetEntities(SchoolContext entityContext)
        {
            throw new NotImplementedException();
        }

        protected override ClientClassSubjects GetEntity(SchoolContext entityContext, ClassSubjects entity)
        {
            throw new NotImplementedException();
        }

        protected override ClientClassSubjects GetEntity(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override bool Remove(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override ClassSubjects UpdateEntity(SchoolContext entityContext, ClassSubjects entity)
        {
            throw new NotImplementedException();
        }
    }
}
