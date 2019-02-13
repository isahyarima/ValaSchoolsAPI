using School.Business.GradeSetting;
using School.Client.Business.AcademicSettings;
using School.Data.Contracts.GradeSettingContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.GradeSettingRepository
{
    class GradeSettingRepository : DataRepositoryBase<GradeSetting, ClientGradeSetting>, IGradeSettingRepository
    {
        protected override GradeSetting AddEntity(SchoolContext entityContext, GradeSetting entity)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<ClientGradeSetting> GetEntities(SchoolContext entityContext)
        {
            throw new NotImplementedException();
        }

        protected override ClientGradeSetting GetEntity(SchoolContext entityContext, GradeSetting entity)
        {
            throw new NotImplementedException();
        }

        protected override GradeSetting GetEntity(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override GradeSetting Remove(SchoolContext entityContext, int id)
        {
            throw new NotImplementedException();
        }

        protected override GradeSetting UpdateEntity(SchoolContext entityContext, GradeSetting entity)
        {
            throw new NotImplementedException();
        }
    }
}
