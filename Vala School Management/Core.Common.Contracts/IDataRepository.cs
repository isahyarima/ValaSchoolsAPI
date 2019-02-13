
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Common.Contracts
{
    public interface IDataRepository
    {

    }

    public interface IDataRepository<T, R> : IDataRepository
        where T : class, IIdentifiableEntity, new()
    {
        T Add(T entity);

        bool Remove(int id);

        T Update(T entity);

        IEnumerable<R> Get();

        R Get(T entity);
    }
}
