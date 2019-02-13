
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
    public  interface IDataRepositoryString<T,R> : IDataRepositoryString
        where T : class, IIdentifiableEntityString, new()
    {
        bool Add(T entity);

        bool Update(T entity);

        bool Remove(string id);
        IEnumerable<R> Get();

        R Get(string id);
    }
}
