using School.Business.AcademicSession;
using School.Client.Business.AcademicSettings;
using School.Data.Contracts.SessionContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.AcademicSettingRepository
{
    public class AcademicSessionRepository : DataRepositoryBaseString<AcademicSession, ClientAcademicSession>, IAcademicSessionRepository
    {
        protected override AcademicSession AddEntity(SchoolContext entityContext, AcademicSession entity)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<ClientAcademicSession> GetEntities(SchoolContext entityContext)
        {
            throw new NotImplementedException();
        }

        protected override ClientAcademicSession GetEntity(SchoolContext entityContext, AcademicSession entity)
        {
            throw new NotImplementedException();
        }

        protected override AcademicSession GetEntity(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override AcademicSession UpdateEntity(SchoolContext entityContext, AcademicSession entity)
        {
            throw new NotImplementedException();
        }
    }
}
