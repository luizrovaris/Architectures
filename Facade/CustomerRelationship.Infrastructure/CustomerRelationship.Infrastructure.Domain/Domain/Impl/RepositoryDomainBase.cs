using CustomerRelationship.Infrastructure.Model.BaseModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CustomerRelationship.Infrastructure.Domain.Domain.Impl
{
    /// <summary>
    /// Used as repository domain base CRUD methods
    /// </summary>
    /// <typeparam name="TEntity">Entity</typeparam>
    /// <typeparam name="TRepo">Repository</typeparam>
    public class RepositoryDomainBase<TEntity, TRepo> : DomainBase, IRepositoryDomainBase<TEntity>
                where TEntity : IdentificationBaseEntity
                where TRepo : DbContext
    {
        protected readonly TRepo _context;
        public RepositoryDomainBase(TRepo context)
        {
            this._context = context;
        }

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetEntityById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            TEntity entity = this.GetEntityById(id);

            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
