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
    public class EmployeeRepository : DataRepositoryBaseString<Employee, ClientEmployee>, IEmployeeRepository
    {
        protected override Employee AddEntity(SchoolContext entityContext, Employee entity)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<ClientEmployee> GetEntities(SchoolContext entityContext)
        {
            throw new NotImplementedException();
        }

        protected override ClientEmployee GetEntity(SchoolContext entityContext, Employee entity)
        {
            throw new NotImplementedException();
        }

        protected override Employee GetEntity(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override Employee UpdateEntity(SchoolContext entityContext, Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
