
using Core.Common.Contracts;
using School.Business.Students;
using School.Client.Business.Students;

namespace School.Data.Contracts
{
    public interface IStudentRepository : IDataRepositoryString<Student, ClientStudent>
    {
    }
}
