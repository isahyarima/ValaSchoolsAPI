using School.Business.Subjects;
using School.Client.Business.SubjectRegistration;
using School.Data.Contracts.SubjectsContracts;
using System;
using System.Collections.Generic;

namespace School.Data.SubjectsRepository
{
    public class SubjectsRepository : DataRepositoryBase<Subjects, ClientSubjects>, ISubjectsRepository
    {
        protected override Subjects AddEntity(SchoolContext entityContext, Subjects entity)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<ClientSubjects> GetEntities(SchoolContext entityContext)
        {
            throw new NotImplementedException();
        }

        protected override ClientSubjects GetEntity(SchoolContext entityContext, Subjects entity)
        {
            throw new NotImplementedException();
        }

        protected override ClientSubjects GetEntity(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override bool Remove(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override Subjects UpdateEntity(SchoolContext entityContext, Subjects entity)
        {
            throw new NotImplementedException();
        }
    }
}
