using School.Business.ClassSubjects.Entities;
using School.Client.Business.ClassSubjects;
using School.Data.Contracts.ClassSubjectsContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        protected override ClassSubjects GetEntity(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override ClassSubjects Remove(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override ClassSubjects UpdateEntity(SchoolContext entityContext, ClassSubjects entity)
        {
            throw new NotImplementedException();
        }
    }
}
