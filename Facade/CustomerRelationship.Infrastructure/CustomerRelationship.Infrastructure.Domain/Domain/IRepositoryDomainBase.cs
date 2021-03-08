using CustomerRelationship.Infrastructure.Model.BaseModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomerRelationship.Infrastructure.Domain.Domain
{
    /// <summary>
    /// Used as repository domain base interface
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IRepositoryDomainBase<TEntity> : IDisposable, IDomainBase
           where TEntity : IdentificationBaseEntity
    {
        Task AddAsync(TEntity entity);
        Task<TEntity> GetEntityByIdAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(int id);
    }
}
