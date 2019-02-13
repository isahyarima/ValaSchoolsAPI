using Core.Common.Contracts;
using School.Business.Subjects;
using School.Client.Business.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Contracts.SubjectsContracts
{
    public interface ISubjectsRepository : IDataRepository<Subjects, ClientSubjects>
    {

    }
}
