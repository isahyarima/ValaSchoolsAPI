
using School.Common.Contracts;
using School.Students.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.StudentContracts
{
    public interface IStudentRepository : IDataRepositoryString<Student>
    {
    }
}
