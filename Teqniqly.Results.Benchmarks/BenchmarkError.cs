namespace Teqniqly.Results.Benchmarks;

/// <summary>
/// A concrete error type used for benchmarking purposes.
/// </summary>
internal sealed record BenchmarkError(string Message) : Error(Message);
