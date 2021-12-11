namespace DotNet.WebApi.Domain.Models.Abstractions
{
    /// <summary>
    /// Interface for models with ids
    /// </summary>
    /// <typeparam name="TKey">Type of id property</typeparam>
    public interface IIdModel<TKey>
        where TKey : IEquatable<TKey>
    {
        /// <summary>
        /// Identifier of entry
        /// </summary>
        public TKey Id { get; set; }
    }
}