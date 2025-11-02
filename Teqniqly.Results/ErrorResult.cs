namespace Teqniqly.Results
{
  public sealed class ErrorResult<T> : IResult<T>
  {
    private readonly IError _error;

    public ErrorResult(IError error) => _error = error;

    public bool IsFailure => true;
    public bool IsSuccess => false;

    public IError GetError() => _error;

    public T GetValue() => default!;
  }
}
