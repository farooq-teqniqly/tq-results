namespace Teqniqly.Results
{
  internal sealed class ErrorResult<T> : IResult<T>
  {
    private readonly T _error;

    public ErrorResult(T error) => _error = error;

    public bool IsFailure => true;
    public bool IsSuccess => false;

    public T GetValue() => _error;
  }
}
