using Core.Common.Contracts;
using School.Business.ClassEnrolment;
using School.Client.Business.ClassEnrolment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Contracts.ClassEnrolmentContracts
{
   public interface IClassEnrolmentRepository : IDataRepository<ClassEnrolment, ClientClassEnrolment>
    {
    }
}
