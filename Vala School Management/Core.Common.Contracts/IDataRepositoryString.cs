
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core.Common.Contracts
{
    public interface IDataRepositoryString
    {

    }
    public interface IDataRepositoryString<T, R> : IDataRepositoryString
        where T : class, IIdentifiableEntityString, new()
    {
        T Add(T entity);

        int Remove(int id);

        T Update(T entity);

        IEnumerable<R> Get();

        R Get(T entity);
    }
}
