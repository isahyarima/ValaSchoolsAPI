using School.Common.Contracts;
using School.Common.Repository;
using School.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Repository
{
    public abstract class DataRepositoryBaseString<T> : DataRepositoryBaseString<T, SchoolContext>
          where T : class, IIdentifiableEntityString, new()
    {
    }
}
