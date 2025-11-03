namespace Teqniqly.Results
{
    /// <summary>
    /// Represents the result of an operation that can either succeed or fail.
    /// This interface provides a common contract for handling operation outcomes.
    /// </summary>
    /// <typeparam name="T">The type of the value returned on success.</typeparam>
    public interface IResult<out T>
    {
        /// <summary>
        /// Gets a value indicating whether the operation failed.
        /// </summary>
        public bool IsFailure { get; }

        /// <summary>
        /// Gets a value indicating whether the operation succeeded.
        /// </summary>
        public bool IsSuccess { get; }

        /// <summary>
        /// Gets the error that occurred during the operation, if any.
        /// </summary>
        /// <returns>The error details.</returns>
        public Error GetError();

        /// <summary>
        /// Gets the value returned by the operation on success.
        /// </summary>
        /// <returns>The operation result value.</returns>
        public T GetValue();
    }

    /// <summary>
    /// Provides factory methods for creating result instances.
    /// This static class contains convenience methods for creating success and failure results.
    /// </summary>
    public static class Result
    {
        /// <summary>
        /// Creates a failed result with the specified error.
        /// </summary>
        /// <typeparam name="T">The type of the value that would have been returned on success.</typeparam>
        /// <param name="error">The error that occurred.</param>
        /// <returns>A result representing failure.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="error"/> is null.</exception>
        public static IResult<T> Failure<T>(Error error)
        {
            ArgumentNullException.ThrowIfNull(error);
            return new ErrorResult<T>(error);
        }

        /// <summary>
        /// Creates a successful result with the specified value.
        /// </summary>
        /// <typeparam name="T">The type of the result value.</typeparam>
        /// <param name="value">The value returned by the successful operation.</param>
        /// <returns>A result representing success.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is null.</exception>
        public static IResult<T> Success<T>(T value)
        {
            ArgumentNullException.ThrowIfNull(value);
            return new SuccessResult<T>(value);
        }
    }
}
