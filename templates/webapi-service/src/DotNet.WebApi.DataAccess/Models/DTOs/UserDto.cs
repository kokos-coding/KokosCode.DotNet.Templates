namespace DotNet.WebApi.DataAccess.Models.DTOs
{
    /// <summary>
    /// Dto for User
    /// </summary>
    internal class UserDto
    {
        /// <summary>
        /// Identifier
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// First name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Middle name
        /// </summary>
        public string MiddleName { get; set; }
        /// <summary>
        /// Last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Age
        /// </summary>
        public int Age { get; set; }
    }
}