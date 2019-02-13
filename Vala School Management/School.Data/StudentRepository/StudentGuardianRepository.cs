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
    public class StudentGuardianRepository : DataRepositoryBaseString<StudentGuardian, ClientStudentGuardian>, IStudentGuardianRepository
    {
        protected override StudentGuardian AddEntity(SchoolContext entityContext, StudentGuardian entity)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<ClientStudentGuardian> GetEntities(SchoolContext entityContext)
        {
            throw new NotImplementedException();
        }

        protected override ClientStudentGuardian GetEntity(SchoolContext entityContext, StudentGuardian entity)
        {
            throw new NotImplementedException();
        }

        protected override StudentGuardian GetEntity(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override StudentGuardian UpdateEntity(SchoolContext entityContext, StudentGuardian entity)
        {
            throw new NotImplementedException();
        }
    }
}
