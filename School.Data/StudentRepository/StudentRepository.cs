

using School.Business.Students;
using School.Client.Business.Students;
using School.Data.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace School.Data.StudentRepository
{
    public class StudentRepository : DataRepositoryBaseString<Student, ClientStudent>, IStudentRepository
    {
        protected override Student AddEntity(SchoolContext entityContext, Student entity)
        {
            throw new NotImplementedException();
        }

        protected override bool DeleteEntity(SchoolContext entityContext, string id)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<ClientStudent> GetEntities(SchoolContext entityContext)
        {
            throw new NotImplementedException();
        }

        protected override ClientStudent GetEntity(SchoolContext entityContext, Student entity)
        {
            throw new NotImplementedException();
        }

        protected override ClientStudent GetEntity(SchoolContext entityContext, string id)
        {
            throw new NotImplementedException();
        }

        protected override Student UpdateEntity(SchoolContext entityContext, Student entity)
        {
            throw new NotImplementedException();
        }
    }

}
