using System;
using Test.WebApi.Domain.Models.Common.Abstractions;

namespace DotNet.WebApi.Domain.Models.Common
{
    /// <inheritdoc />
    public class IdModel<TKey> : IIdModel<TKey>
        where TKey : IEquatable<TKey>
    {
        /// <inheritdoc />
        public TKey Id { get; set; }
    }
}