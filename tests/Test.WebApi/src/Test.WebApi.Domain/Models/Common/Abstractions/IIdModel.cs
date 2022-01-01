using System;

namespace Test.WebApi.Domain.Models.Common.Abstractions
{
    /// <summary>
    /// Model with identifier
    /// </summary>
    /// <typeparam name="TKey">Type of identifier</typeparam>
    public interface IIdModel<TKey> where TKey : IEquatable<TKey>
    {
        /// <summary>
        /// Identifier of model
        /// </summary>
        TKey Id { get; set; }
    }
}