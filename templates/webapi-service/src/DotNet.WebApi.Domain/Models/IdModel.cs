using DotNet.WebApi.Domain.Models.Abstractions;

namespace DotNet.WebApi.Domain.Models
{
    public class IdModel<TKey> : IIdModel<TKey>
        where TKey : IEquatable<TKey>
    {
        /// <inheritdoc cref="Id" />
        public TKey Id { get; set; }
    }
}