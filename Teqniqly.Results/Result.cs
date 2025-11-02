namespace Teqniqly.Results
{
    public interface IResult<out T>
    {
        public bool IsFailure { get; }
        public bool IsSuccess { get; }
        public Error GetError();
        public T GetValue();
    }

    public static class Result
    {
        public static IResult<T> Failure<T>(Error error) => new ErrorResult<T>(error);

        public static IResult<T> Success<T>(T value) => new SuccessResult<T>(value);
    }
}
