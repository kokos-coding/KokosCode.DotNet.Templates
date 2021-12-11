namespace DotNet.WebApi.Domain.AggregationModels.User
{
    /// <summary>
    /// Value object for represent user email
    /// </summary>
    public class Email
    {
        /// <summary>
        /// Constructor for create email address
        /// </summary>
        /// <param name="email">Email string</param>
        public Email(string email)
        {
            
        }
    
        /// <summary>
        /// Email value
        /// </summary>
        public string Value { get; }
    }
}