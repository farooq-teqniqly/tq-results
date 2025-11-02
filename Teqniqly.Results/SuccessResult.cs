namespace Teqniqly.Results;

internal sealed class SuccessResult<T> : IResult<T>
{
  private readonly T _value;

  public SuccessResult(T value) => _value = value;

  public bool IsFailure => false;
  public bool IsSuccess => true;

  public T GetValue() => _value;
}
