
using Core.Common.Contracts;
using School.Business.Employees;
using School.Client.Business.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Contracts
{
  public  interface IEmployeeExperiencesRepository : IDataRepositoryString<EmployeeExperiences, ClientEmployeeExperiences>
    {
       
    }
}
