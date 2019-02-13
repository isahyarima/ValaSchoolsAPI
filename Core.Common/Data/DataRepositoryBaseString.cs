
using Core.Common.Contracts;
using Core.Common.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common.Data
{
    public abstract class DataRepositoryBaseString<T,R, U> : IDataRepositoryString<T,R>
        where T : class, IIdentifiableEntityString, new()
        where U : DbContext, new()
    {
        protected abstract T AddEntity(U entityContext, T entity);

        protected abstract T UpdateEntity(U entityContext, T entity);

        protected abstract IEnumerable<R> GetEntities(U entityContext);

        protected abstract R GetEntity(U entityContext, T entity);

        protected abstract R GetEntity(U entityContext, string id);

        protected abstract bool DeleteEntity(U entityContext, string id);

        public bool Add(T entity)
        {
            using (U entityContext = new U())
            {
                T addedEntity = AddEntity(entityContext, entity);
                if (entityContext.SaveChanges() > 0)
                    return true;
                return false;
            }
        }

        
        public bool Update(T entity)
        {
            using (U entityContext = new U())
            {
                T existingEntity = UpdateEntity(entityContext, entity);

                SimpleMapper.PropertyMap(entity, existingEntity);

                if (entityContext.SaveChanges() > 0)
                    return true;
                return false;
            }
        }

        public IEnumerable<R> Get()
        {
            using (U entityContext = new U())
                return (GetEntities(entityContext)).ToArray().ToList();
        }

        public R Get(T entity)
        {
            using (U entityContext = new U())
                return GetEntity(entityContext, entity);
        }

        public R Get(string id)
        {
            using (U entityContext = new U())
                return GetEntity(entityContext, id);
        }

        public bool Remove(string id)
        {
            using (U entityContext = new U())
                return DeleteEntity(entityContext, id);
        }
    }
}
