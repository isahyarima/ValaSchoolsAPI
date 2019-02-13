using School.Business.AcademicSession;
using School.Client.Business.AcademicSetting;
using School.Data.Contracts.SessionContracts;
using System;
using System.Collections.Generic;

namespace School.Data.AcademicSettingRepository
{
    public class AcademicSessionRepository : DataRepositoryBaseString<AcademicSession, ClientAcademicSession>, IAcademicSessionRepository
    {
        protected override AcademicSession AddEntity(SchoolContext entityContext, AcademicSession entity)
        {
          return  entityContext.AcademicSessionSet.Add(entity);
        }

        protected override bool DeleteEntity(SchoolContext entityContext, string id)
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

        protected override ClientAcademicSession GetEntity(SchoolContext entityContext, string id)
        {
            throw new NotImplementedException();
        }

        protected override AcademicSession UpdateEntity(SchoolContext entityContext, AcademicSession entity)
        {
            throw new NotImplementedException();
        }
    }
}
