namespace Teqniqly.Results
{
  public static class Result
  {
    public static Result<T> Failure<T>(Error error) => new ErrorResult<T>(error);

    public static Result<T> Success<T>(T value) => new SuccessResult<T>(value);
  }

  public abstract class Result<T>
  {
    public abstract bool IsFailure { get; }
    public abstract bool IsSuccess { get; }
    public abstract Error GetError();
    public abstract T GetValue();
  }
}
