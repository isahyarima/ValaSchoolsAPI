using Core.Common.Contracts;
using School.Business.Classes.Entities;
using School.Client.Business.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Contracts.ClassesContracts
{
    public interface ISectionReportsitory : IDataRepository<Section, ClientSection>
    {
    }
}
