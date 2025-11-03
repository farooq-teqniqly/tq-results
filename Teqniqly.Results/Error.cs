namespace Teqniqly.Results
{
    /// <summary>
    /// Represents an error that occurred during an operation.
    /// This abstract record serves as the base class for all error types in the results system.
    /// </summary>
    /// <param name="Message">A human-readable description of the error.</param>
    public abstract record Error(string Message);
}
