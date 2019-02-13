
using Core.Common.Contracts;
using Core.Common.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data
{
    public abstract class DataRepositoryBaseString<T,R> : DataRepositoryBaseString<T,R, SchoolContext>
        where T : class, IIdentifiableEntityString, new()
    {

    }
}
