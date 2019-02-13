using School.Business.Employees;
using School.Client.Business.Employees;
using School.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data
{
    public class EmployeeContactRepository : DataRepositoryBaseString<EmployeeContact, ClientEmployeeContact>, IEmployeeContactRepository
    {
        protected override EmployeeContact AddEntity(SchoolContext entityContext, EmployeeContact entity)
        {
            throw new NotImplementedException();
        }

        protected override bool DeleteEntity(SchoolContext entityContext, string id)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<ClientEmployeeContact> GetEntities(SchoolContext entityContext)
        {
            throw new NotImplementedException();
        }

        protected override ClientEmployeeContact GetEntity(SchoolContext entityContext, EmployeeContact entity)
        {
            throw new NotImplementedException();
        }

        protected override ClientEmployeeContact GetEntity(SchoolContext entityContext, string id)
        {
            throw new NotImplementedException();
        }

        protected override EmployeeContact UpdateEntity(SchoolContext entityContext, EmployeeContact entity)
        {
            throw new NotImplementedException();
        }
    }
}
