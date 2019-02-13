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
    public class EmployeeExperiencesRepository : DataRepositoryBaseString<EmployeeExperiences, ClientEmployeeExperiences>, IEmployeeExperiencesRepository
    {
        protected override EmployeeExperiences AddEntity(SchoolContext entityContext, EmployeeExperiences entity)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<ClientEmployeeExperiences> GetEntities(SchoolContext entityContext)
        {
            throw new NotImplementedException();
        }

        protected override ClientEmployeeExperiences GetEntity(SchoolContext entityContext, EmployeeExperiences entity)
        {
            throw new NotImplementedException();
        }

        protected override EmployeeExperiences GetEntity(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override EmployeeExperiences UpdateEntity(SchoolContext entityContext, EmployeeExperiences entity)
        {
            throw new NotImplementedException();
        }
    }
}
