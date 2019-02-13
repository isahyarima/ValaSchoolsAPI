using School.Business.Students;
using School.Client.Business.Students;
using School.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.StudentRepository
{
    public class StudentHealthRepository : DataRepositoryBaseString<StudentHealth, ClientStudentHealth>, IStudentHealthRepository
    {
        protected override StudentHealth AddEntity(SchoolContext entityContext, StudentHealth entity)
        {
            throw new NotImplementedException();
        }

        protected override bool DeleteEntity(SchoolContext entityContext, string id)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<ClientStudentHealth> GetEntities(SchoolContext entityContext)
        {
            throw new NotImplementedException();
        }

        protected override ClientStudentHealth GetEntity(SchoolContext entityContext, StudentHealth entity)
        {
            throw new NotImplementedException();
        }

        protected override ClientStudentHealth GetEntity(SchoolContext entityContext, string id)
        {
            throw new NotImplementedException();
        }

        protected override StudentHealth UpdateEntity(SchoolContext entityContext, StudentHealth entity)
        {
            throw new NotImplementedException();
        }
    }
}
