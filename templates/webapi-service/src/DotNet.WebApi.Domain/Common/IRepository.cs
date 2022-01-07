using System;
using System.Threading;
using System.Threading.Tasks;
using DotNet.WebApi.Domain.Models.Common.Abstractions;

namespace DotNet.WebApi.Domain.Common
{
    public interface IRepository<TEntity, TKey>
        where TEntity : class, IIdModel<TKey>
        where TKey : IEquatable<TKey>
    {
        Task<TKey> CreateAsync(TEntity entity, CancellationToken cancellationToken);
        Task UpdateAsync(TEntity entity, CancellationToken cancellationToken);
        ValueTask DeleteAsync(TEntity entity, CancellationToken cancellationToken);        
        Task<TEntity> GetByIdAsync(TKey id, CancellationToken cancellationToken);
    }
}