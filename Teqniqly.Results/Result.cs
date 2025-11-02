namespace Teqniqly.Results
{
  public interface IResult<out T>
  {
    bool IsFailure { get; }
    bool IsSuccess { get; }
    T GetValue();
  }

  public static class Result
  {
    public static IResult<T> Failure<T>(T error) => new ErrorResult<T>(error);

    public static IResult<T> Success<T>(T value) => new SuccessResult<T>(value);
  }
}
