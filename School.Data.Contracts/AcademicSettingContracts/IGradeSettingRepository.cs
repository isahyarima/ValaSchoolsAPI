using Core.Common.Contracts;
using School.Business.GradeSetting;
using School.Client.Business.AcademicSetting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Contracts.AcademicSettingContracts
{
   public interface IGradeSettingRepository : IDataRepository<GradeSetting, ClientGradeSetting>
    {
    }
}
