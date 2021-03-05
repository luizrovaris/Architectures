using CustomerRelationship.Infrastructure.Model.BaseModel;
using System;
using System.Collections.Generic;

namespace CustomerRelationship.Infrastructure.Domain.Domain
{
    /// <summary>
    /// Used as repository domain base interface
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IRepositoryDomainBase<TEntity> : IDisposable, IDomainBase
           where TEntity : IdentificationBaseEntity
    {
        void Add(TEntity entity);
        TEntity GetEntityById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity entity);
        void Delete(int id);
    }
}
