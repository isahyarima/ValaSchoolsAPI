using Core.Common.Contracts;
using School.Business.Classes;
using School.Client.Business.SchoolClasses;

namespace School.Data.Contracts.ClassesContracts
{
    public interface IClassesRepository : IDataRepository<Classes,ClientClasses>
    {
    }
}
