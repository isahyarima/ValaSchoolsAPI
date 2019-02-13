using Core.Common.Contracts;
using School.Business.Parents;
using School.Client.Business.Guardian;

namespace School.Data.Contracts.ParentsContracts
{
    public interface IFatherRepository : IDataRepositoryString<Father, ClientFather>
    {
    }
}
