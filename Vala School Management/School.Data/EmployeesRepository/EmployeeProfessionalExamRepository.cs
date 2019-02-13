using School.Business.Employees;
using School.Client.Business.Employees;
using School.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.EmployeesRepository
{
    public class EmployeeProfessionalExamRepository : DataRepositoryBaseString<EmployeeProfessionalExam, ClientEmployeeProfessionalExam>, IEmployeeProfessionalExamRepository
    {
        protected override EmployeeProfessionalExam AddEntity(SchoolContext entityContext, EmployeeProfessionalExam entity)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<ClientEmployeeProfessionalExam> GetEntities(SchoolContext entityContext)
        {
            throw new NotImplementedException();
        }

        protected override ClientEmployeeProfessionalExam GetEntity(SchoolContext entityContext, EmployeeProfessionalExam entity)
        {
            throw new NotImplementedException();
        }

        protected override EmployeeProfessionalExam GetEntity(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override EmployeeProfessionalExam UpdateEntity(SchoolContext entityContext, EmployeeProfessionalExam entity)
        {
            throw new NotImplementedException();
        }
    }
}
