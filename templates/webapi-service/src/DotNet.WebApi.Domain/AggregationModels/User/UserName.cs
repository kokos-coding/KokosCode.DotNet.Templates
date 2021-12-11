namespace DotNet.WebApi.Domain.AggregationModels.User
{
    /// <summary>
    /// Value object for user name
    /// </summary>
    public class UserName
    {
        /// <summary>
        /// Constructor for user name with first and last name
        /// </summary>
        /// <param name="firstName">User first name</param>
        /// <param name="lastName">User last name</param>
        public UserName(string firstName, string lastName)
        {
            FirstName = firstName;
            MiddleName = string.Empty;
            LastName = lastName;
        }

        /// <summary>
        /// Constructor for user name with first middle and last name
        /// </summary>
        /// <param name="firstName">User first name</param>
        /// <param name="middleName">User middle name</param>
        /// <param name="lastName">User last name</param>
        public UserName(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        /// <summary>
        /// User first name
        /// </summary>
        public string FirstName { get; }

        /// <summary>
        /// User last name
        /// </summary>
        public string LastName { get; }
        
        /// <summary>
        /// User middle name
        /// </summary>
        public string MiddleName { get; }

        /// <summary>
        /// User full name
        /// </summary>
        public string FullName => string.IsNullOrWhiteSpace(MiddleName) ?
            $"{FirstName} {LastName}" :
            $"{FirstName} {MiddleName} {LastName}";
    }
}
