
using Core.Common.Contracts;
using School.Business.Students;
using School.Client.Business.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Contracts
{
    public interface IStudentGuardianRepository : IDataRepositoryString<StudentGuardian, ClientStudentGuardian>
    {
    }
}
