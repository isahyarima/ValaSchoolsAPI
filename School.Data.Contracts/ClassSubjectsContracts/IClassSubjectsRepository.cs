using Core.Common.Contracts;
using School.Business.ClassSubjects.Entities;
using School.Client.Business.ClassSubject;

namespace School.Data.Contracts.ClassSubjectsContracts
{
    public interface IClassSubjectsRepository : IDataRepository<ClassSubjects, ClientClassSubjects>
    {
    }
}
