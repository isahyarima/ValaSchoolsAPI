using School.Data.Contracts;
using Core.Common;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Business.Employees;
using School.Client.Business.Employees;

namespace School.Data
{
    public class EmployeeAcademicRecordRepository : DataRepositoryBaseString<EmployeeAcademicRecord, ClientEmployeeAcademicRecord>, IEmployeeAcademicRecordRepository
    {
        protected override EmployeeAcademicRecord AddEntity(SchoolContext entityContext, EmployeeAcademicRecord entity)
        {
            throw new NotImplementedException();
        }

        protected override bool DeleteEntity(SchoolContext entityContext, string id)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<ClientEmployeeAcademicRecord> GetEntities(SchoolContext entityContext)
        {
            throw new NotImplementedException();
        }

        protected override ClientEmployeeAcademicRecord GetEntity(SchoolContext entityContext, EmployeeAcademicRecord entity)
        {
            throw new NotImplementedException();
        }

        protected override ClientEmployeeAcademicRecord GetEntity(SchoolContext entityContext, string id)
        {
            throw new NotImplementedException();
        }

        protected override EmployeeAcademicRecord UpdateEntity(SchoolContext entityContext, EmployeeAcademicRecord entity)
        {
            throw new NotImplementedException();
        }
    }
}
