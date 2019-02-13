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
    public class EmployeeOlevelRepository : DataRepositoryBaseString<EmployeeOlevel, ClientEmployeeOlevel>, IEmployeeOlevelRepository
    {
        protected override EmployeeOlevel AddEntity(SchoolContext entityContext, EmployeeOlevel entity)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<ClientEmployeeOlevel> GetEntities(SchoolContext entityContext)
        {
            throw new NotImplementedException();
        }

        protected override ClientEmployeeOlevel GetEntity(SchoolContext entityContext, EmployeeOlevel entity)
        {
            throw new NotImplementedException();
        }

        protected override EmployeeOlevel GetEntity(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override EmployeeOlevel UpdateEntity(SchoolContext entityContext, EmployeeOlevel entity)
        {
            throw new NotImplementedException();
        }
    }
}
