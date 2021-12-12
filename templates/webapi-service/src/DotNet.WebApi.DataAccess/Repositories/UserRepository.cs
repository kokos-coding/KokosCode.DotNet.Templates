using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNet.WebApi.Domain.AggregationModels.User;

namespace DotNet.WebApi.DataAccess.Repositories
{
    /// <summary>
    /// Repository for manage User entity
    /// </summary>
    public class UserRepository : IUserRepository
    {
        public UserRepository()
        {

        }

        /// <inheritdoc cref="CreateAsync" />
        public Task<Guid> CreateAsync(User entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="DeleteAsync" />
        public ValueTask DeleteAsync(User entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="GetByEmailAsync" />
        public Task<User> GetByEmailAsync(Email email, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="GetByIdAsync" />
        public Task<User> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="UpdateAsync" />
        public Task UpdateAsync(User entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}