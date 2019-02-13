using School.Business.Subjects;
using School.Client.Business.Subjects;
using School.Data.Contracts.SubjectsContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        protected override Subjects GetEntity(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override Subjects Remove(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override Subjects UpdateEntity(SchoolContext entityContext, Subjects entity)
        {
            throw new NotImplementedException();
        }
    }
}
