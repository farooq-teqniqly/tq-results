namespace Teqniqly.Results
{
    internal sealed class ErrorResult<T> : IResult<T>
    {
        private readonly Error _error;

        public ErrorResult(Error error) => _error = error;

        public bool IsFailure => true;
        public bool IsSuccess => false;

        public Error GetError() => _error;

        public T GetValue() => default!;
    }
}
