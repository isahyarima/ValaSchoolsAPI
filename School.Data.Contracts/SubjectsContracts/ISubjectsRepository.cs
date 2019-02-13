using Core.Common.Contracts;
using School.Business.Subjects;
using School.Client.Business.SubjectRegistration;

namespace School.Data.Contracts.SubjectsContracts
{
    public interface ISubjectsRepository : IDataRepository<Subjects, ClientSubjects>
    {

    }
}
