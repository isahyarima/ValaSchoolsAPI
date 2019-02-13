using Core.Common.Contracts;
using School.Business.AcademicSession;
using School.Client.Business.AcademicSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Contracts.SessionContracts
{
    public interface IAcademicSessionRepository : IDataRepositoryString<AcademicSession, ClientAcademicSession>
    {
    }
}
