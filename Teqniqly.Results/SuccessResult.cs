namespace Teqniqly.Results;

public sealed class SuccessResult<T> : IResult<T>
{
  private readonly T _value;

  public SuccessResult(T value) => _value = value;

  public bool IsFailure => false;
  public bool IsSuccess => true;

  public IError GetError() => null!;

  public T GetValue() => _value;
}
