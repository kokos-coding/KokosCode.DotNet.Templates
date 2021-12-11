using DotNet.WebApi.Domain.Common;

namespace DotNet.WebApi.Domain.AggregationModels.User
{
    public interface IUserRepository : IRepository<User, Guid>
    {
        Task<User> GetByEmailAsync(Email email, CancellationToken cancellationToken);
    }
}