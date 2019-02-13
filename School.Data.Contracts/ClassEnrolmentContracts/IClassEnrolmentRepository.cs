using Core.Common.Contracts;
using School.Business.ClassEnrolment;
using School.Client.Business.ClassEnrolments;

namespace School.Data.Contracts.ClassEnrolmentContracts
{
    public interface IClassEnrolmentRepository : IDataRepository<ClassEnrolment, ClientClassEnrolment>
    {
    }
}
