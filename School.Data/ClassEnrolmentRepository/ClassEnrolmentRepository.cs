using School.Business.ClassEnrolment;
using School.Client.Business.ClassEnrolments;
using School.Data.Contracts.ClassEnrolmentContracts;
using System;
using System.Collections.Generic;

namespace School.Data.ClassEnrolmentRepository
{
    public class ClassEnrolmentRepository : DataRepositoryBase<ClassEnrolment, ClientClassEnrolment>, IClassEnrolmentRepository
    {
        protected override ClassEnrolment AddEntity(SchoolContext entityContext, ClassEnrolment entity)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<ClientClassEnrolment> GetEntities(SchoolContext entityContext)
        {
            throw new NotImplementedException();
        }

        protected override ClientClassEnrolment GetEntity(SchoolContext entityContext, ClassEnrolment entity)
        {
            throw new NotImplementedException();
        }

        protected override ClientClassEnrolment GetEntity(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override bool Remove(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override ClassEnrolment UpdateEntity(SchoolContext entityContext, ClassEnrolment entity)
        {
            throw new NotImplementedException();
        }
    }
}
