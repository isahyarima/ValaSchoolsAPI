using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Common.Contracts
{
   public interface IDataRepositoryString
    {
    }
    public interface IDataRepositoryString<T> : IDataRepository
    where T : class, IIdentifiableEntityString, new()
    {
        T Add(T entity);

        void Remove(T entity);

        void Remove(string id);

        T Update(T entity);

        IEnumerable<T> Get();

        T Get(string id);
    }
}
