using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BackEndTesteGrupoRovema.Contexto;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace BackEndTesteGrupoRovema.Repository
{
    public class RepositoryBase<TEntity> : IDisposable where TEntity : class
    {
        public readonly Context context = new Context();
        public void Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
        }

        public void Update (TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Remove(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
            context.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public IList<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}