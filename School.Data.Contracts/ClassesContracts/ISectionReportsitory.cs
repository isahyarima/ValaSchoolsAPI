using Core.Common.Contracts;
using School.Business.Classes.Entities;
using School.Client.Business.SchoolClasses;

namespace School.Data.Contracts.ClassesContracts
{
    public interface ISectionReportsitory : IDataRepository<Section, ClientSection>
    {
    }
}
