namespace Teqniqly.Results;

/// <summary>
/// Represents a successful result containing a value.
/// This class implements <see cref="IResult{T}"/> and indicates that an operation succeeded.
/// </summary>
/// <typeparam name="T">The type of the value returned by the successful operation.</typeparam>
internal sealed class SuccessResult<T> : IResult<T>
{
    private readonly T _value;

    /// <summary>
    /// Initializes a new instance of the <see cref="SuccessResult{T}"/> class with the specified value.
    /// </summary>
    /// <param name="value">The value returned by the successful operation.</param>
    public SuccessResult(T value) => _value = value;

    /// <inheritdoc/>
    public bool IsFailure => false;

    /// <inheritdoc/>
    public bool IsSuccess => true;

    /// <inheritdoc/>
    public Error GetError() =>
        throw new InvalidOperationException("Cannot retrieve an error from a successful result");

    /// <inheritdoc/>
    public T GetValue() => _value;
}
