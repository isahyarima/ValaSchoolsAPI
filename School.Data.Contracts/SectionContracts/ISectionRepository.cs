using Core.Common.Contracts;
using School.Business.Classes.Entities;
using School.Client.Business.SchoolClasses;

namespace School.Data.Contracts.SectionContracts
{
    public interface ISectionRepository : IDataRepository<Section, ClientSection>
    {
    }
}
