using Core.Common.Contracts;
using School.Business.Session;
using School.Client.Business.AcademicSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Contracts.AcademicSettingContracts
{
    public interface IAssessmentSettingRepository : IDataRepository<AssessmentSetting, ClientAssessmentSetting>
    {
    }
}
