namespace DotNet.WebApi.Domain.AggregationModels.User
{
    /// <summary>
    /// Age value object
    /// </summary>
    public class Age
    {
        /// <summary>
        /// Constructor for create age value object
        /// </summary>
        /// <param name="value">User Age</param>
        public Age(int value)
        {
            if (!IsValid(value))
            {
                throw new ArgumentException("Age is not valid");
            }

            Value = value;
        }

        /// <summary>
        /// Age value
        /// </summary>
        public int Value { get; }

        /// <summary>
        /// Validate age value
        /// </summary>
        /// <param name="value">Value to check</param>
        /// <returns>Validation result</returns>
        public static bool IsValid(Int32 value)
        {
            return 0 <= value && value <= 120;
        }

        /// <inheritdoc cref="Eduals" />
        public override bool Equals(Object obj)
        {
            return obj is Age other && Value == other.Value;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}