using Core.Common.Contracts;
using School.Business.GradeSetting;
using School.Client.Business.AcademicSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Contracts.GradeSettingContracts
{
    public interface IGradeSettingRepository : IDataRepository<GradeSetting, ClientGradeSetting> 
    {
    }
}
