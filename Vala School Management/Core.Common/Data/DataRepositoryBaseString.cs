
using Core.Common.Contracts;
using Core.Common.Utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common.Data
{
    public abstract class DataRepositoryBaseString<T, R, U> : IDataRepositoryString<T, R>
       where T : class, IIdentifiableEntityString, new()
       where U : DbContext, new()
    {
        protected abstract T AddEntity(U entityContext, T entity);

        protected abstract T UpdateEntity(U entityContext, T entity);

        protected abstract IEnumerable<R> GetEntities(U entityContext);

        protected abstract R GetEntity(U entityContext, T entity);

        protected abstract T GetEntity(U entityContext, int id);

        public T Add(T entity)
        {
            using (U entityContext = new U())
            {
                T addedEntity = AddEntity(entityContext, entity);
                entityContext.SaveChanges();
                return addedEntity;
            }
        }

        public int Remove(int id)
        {
            using (U entityContext = new U())
            {
                T entity = GetEntity(entityContext, id);
                entityContext.Entry<T>(entity).State = EntityState.Deleted;
                return entityContext.SaveChanges();
            }
        }

        public T Update(T entity)
        {
            using (U entityContext = new U())
            {
                T existingEntity = UpdateEntity(entityContext, entity);

                SimpleMapper.PropertyMap(entity, existingEntity);

                entityContext.SaveChanges();
                return existingEntity;
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



    }
}
