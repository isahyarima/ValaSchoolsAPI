using Core.Common.Contracts;
using School.Business.AcademicSession;
using School.Client.Business.AcademicSetting;

namespace School.Data.Contracts.SessionContracts
{
    public interface IAcademicSessionRepository : IDataRepositoryString<AcademicSession, ClientAcademicSession>
    {
    }
}
