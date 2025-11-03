namespace Teqniqly.Results
{
    /// <summary>
    /// Represents a failed result containing an error.
    /// This class implements <see cref="IResult{T}"/> and indicates that an operation failed.
    /// </summary>
    /// <typeparam name="T">The type of the value that would have been returned on success.</typeparam>
    internal sealed class ErrorResult<T> : IResult<T>
    {
        private readonly Error _error;

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResult{T}"/> class with the specified error.
        /// </summary>
        /// <param name="error">The error that occurred during the operation.</param>
        public ErrorResult(Error error) => _error = error;

        /// <inheritdoc/>
        public bool IsFailure => true;

        /// <inheritdoc/>
        public bool IsSuccess => false;

        /// <inheritdoc/>
        public Error GetError() => _error;

        /// <inheritdoc/>
        public T GetValue() => default!;
    }
}
