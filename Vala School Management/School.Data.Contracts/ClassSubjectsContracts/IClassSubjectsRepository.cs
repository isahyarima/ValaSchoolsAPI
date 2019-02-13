using Core.Common.Contracts;
using School.Business.ClassSubjects.Entities;
using School.Client.Business.ClassSubjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Contracts.ClassSubjectsContracts
{
    public interface IClassSubjectsRepository : IDataRepository<ClassSubjects, ClientClassSubjects>
    {
    }
}
