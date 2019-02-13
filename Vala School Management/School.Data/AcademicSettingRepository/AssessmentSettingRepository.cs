using School.Business.Session;
using School.Client.Business.AcademicSettings;
using School.Data.Contracts.AcademicSettingContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.AcademicSettingRepository
{
    class AssessmentSettingRepository : DataRepositoryBase<AssessmentSetting, ClientAssessmentSetting>, IAssessmentSettingRepository
    {
  
        protected override AssessmentSetting AddEntity(SchoolContext entityContext, AssessmentSetting entity)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<ClientAssessmentSetting> GetEntities(SchoolContext entityContext)
        {
            throw new NotImplementedException();
        }

        protected override ClientAssessmentSetting GetEntity(SchoolContext entityContext, AssessmentSetting entity)
        {
            throw new NotImplementedException();
        }

        protected override AssessmentSetting GetEntity(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override AssessmentSetting Remove(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override AssessmentSetting UpdateEntity(SchoolContext entityContext, AssessmentSetting entity)
        {
            throw new NotImplementedException();
        }
    }
}
