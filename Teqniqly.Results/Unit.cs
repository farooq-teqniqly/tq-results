namespace Teqniqly.Results
{
    /// <summary>
    /// Represents a unit type, similar to void but with a concrete value.
    /// This type is commonly used when an operation returns no meaningful data but still needs a return type.
    /// </summary>
    public record struct Unit
    {
        /// <summary>
        /// Gets the singleton instance of the Unit type.
        /// </summary>
        public static readonly Unit Value;
    }
}
