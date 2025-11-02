namespace Teqniqly.Results
{
  public interface IResult<out T>
  {
    bool IsFailure { get; }
    bool IsSuccess { get; }
    IError GetError();
    T GetValue();
  }

  public static class Result
  {
    public static IResult<T> Failure<T>(IError error) => new ErrorResult<T>(error);

    public static IResult<T> Success<T>(T value) => new SuccessResult<T>(value);
  }
}
