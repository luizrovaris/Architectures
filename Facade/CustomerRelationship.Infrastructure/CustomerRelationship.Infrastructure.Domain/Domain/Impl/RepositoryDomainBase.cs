using CustomerRelationship.Infrastructure.Model.BaseModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public async Task AddAsync(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetEntityByIdAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            TEntity entity = await this.GetEntityByIdAsync(id);

            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
