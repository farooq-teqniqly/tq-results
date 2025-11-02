namespace Teqniqly.Results
{
  public interface IError
  {
    object Code { get; }
    string Message { get; }
  }

  public abstract record Error<TCode>(TCode Code, string Message) : IError
      where TCode : notnull
  {
    object IError.Code => Code;
  }

  public sealed record StringError(string Code, string Message) : Error<string>(Code, Message);

  public sealed record IntError(int Code, string Message) : Error<int>(Code, Message);
}
