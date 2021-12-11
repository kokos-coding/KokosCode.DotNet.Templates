using DotNet.WebApi.Domain.Models.Abstractions;

namespace DotNet.WebApi.Domain.AggregationModels.User
{
    public class User : IIdModel<Guid>
    {
        /// <summary>
        /// Public constructor
        /// </summary>
        /// <param name="userName">User name</param>
        /// <param name="email">User email</param>
        /// <param name="age">User age</param>
        public User(UserName userName, Email email, Age age)
        {
            UserName = userName ?? throw new ArgumentNullException(nameof(userName));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Age = age ?? throw new ArgumentNullException(nameof(age));

            Id = Guid.NewGuid();
        }

        /// <inheritdoc cref="Id" />
        public Guid Id { get; set; }

        /// <summary>
        /// UserName
        /// </summary>
        public UserName UserName { get; }

        /// <summary>
        /// User email
        /// </summary>
        public Email Email { get; }

        /// <summary>
        /// User age
        /// </summary>
        public Age Age { get; set; }
    }
}