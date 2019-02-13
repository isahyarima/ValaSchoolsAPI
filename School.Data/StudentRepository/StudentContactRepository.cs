using School.Business.Students;
using School.Client.Business.Students;
using School.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data
{
    public class StudentContactRepository : DataRepositoryBaseString<StudentContact, ClientStudentContact>, IStudentContactRepository
    {
        protected override StudentContact AddEntity(SchoolContext entityContext, StudentContact entity)
        {
            throw new NotImplementedException();
        }

        protected override bool DeleteEntity(SchoolContext entityContext, string id)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<ClientStudentContact> GetEntities(SchoolContext entityContext)
        {
            throw new NotImplementedException();
        }

        protected override ClientStudentContact GetEntity(SchoolContext entityContext, StudentContact entity)
        {
            throw new NotImplementedException();
        }

        protected override ClientStudentContact GetEntity(SchoolContext entityContext, string id)
        {
            throw new NotImplementedException();
        }

        protected override StudentContact UpdateEntity(SchoolContext entityContext, StudentContact entity)
        {
            throw new NotImplementedException();
        }
    }
}
