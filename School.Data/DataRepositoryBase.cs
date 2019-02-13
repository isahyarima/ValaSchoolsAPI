
using Core.Common.Contracts;
using Core.Common.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data
{
    public abstract class DataRepositoryBase<T,R> : DataRepositoryBase<T,R, SchoolContext>
        where T : class,IIdentifiableEntity, new()
    {
    }
}
