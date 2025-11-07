using BenchmarkDotNet.Attributes;

namespace Teqniqly.Results.Benchmarks;

/// <summary>
/// CPU benchmarks for the Result library.
/// Measures the performance of creating and accessing results.
/// </summary>
[Config(typeof(CiConfig))]
[MemoryDiagnoser]
public class ResultCpuBenchmarks
{
    private const string TestString = "Test Value";
    private const int TestInt = 42;
    private static readonly BenchmarkError TestError = new("Test error message");

    /// <summary>
    /// Benchmarks creating a successful result with a string value.
    /// </summary>
    [Benchmark]
    public IResult<string> CreateSuccessResult_String()
    {
        return Result.Success(TestString);
    }

    /// <summary>
    /// Benchmarks creating a successful result with an integer value.
    /// </summary>
    [Benchmark]
    public IResult<int> CreateSuccessResult_Int()
    {
        return Result.Success(TestInt);
    }

    /// <summary>
    /// Benchmarks creating a successful result with a Unit value.
    /// </summary>
    [Benchmark]
    public IResult<Unit> CreateSuccessResult_Unit()
    {
        return Result.Success(Unit.Value);
    }

    /// <summary>
    /// Benchmarks creating a failure result with a string type parameter.
    /// </summary>
    [Benchmark]
    public IResult<string> CreateFailureResult_String()
    {
        return Result.Failure<string>(TestError);
    }

    /// <summary>
    /// Benchmarks creating a failure result with an integer type parameter.
    /// </summary>
    [Benchmark]
    public IResult<int> CreateFailureResult_Int()
    {
        return Result.Failure<int>(TestError);
    }

    /// <summary>
    /// Benchmarks creating a failure result with a Unit type parameter.
    /// </summary>
    [Benchmark]
    public IResult<Unit> CreateFailureResult_Unit()
    {
        return Result.Failure<Unit>(TestError);
    }

    /// <summary>
    /// Benchmarks accessing the value from a successful result.
    /// </summary>
    [Benchmark]
    public string GetValue_Success()
    {
        var result = Result.Success(TestString);
        return result.GetValue();
    }

    /// <summary>
    /// Benchmarks accessing the error from a failure result.
    /// </summary>
    [Benchmark]
    public Error GetError_Failure()
    {
        var result = Result.Failure<string>(TestError);
        return result.GetError();
    }

    /// <summary>
    /// Benchmarks checking IsSuccess property on a successful result.
    /// </summary>
    [Benchmark]
    public bool CheckIsSuccess_OnSuccessResult()
    {
        var result = Result.Success(TestString);
        return result.IsSuccess;
    }

    /// <summary>
    /// Benchmarks checking IsFailure property on a failure result.
    /// </summary>
    [Benchmark]
    public bool CheckIsFailure_OnFailureResult()
    {
        var result = Result.Failure<string>(TestError);
        return result.IsFailure;
    }

    /// <summary>
    /// Benchmarks a complete success workflow: create, check, and retrieve value.
    /// </summary>
    [Benchmark]
    public string CompleteSuccessWorkflow()
    {
        var result = Result.Success(TestString);
        if (result.IsSuccess)
        {
            return result.GetValue();
        }
        throw new InvalidOperationException("Unexpected failure");
    }

    /// <summary>
    /// Benchmarks a complete failure workflow: create, check, and retrieve error.
    /// </summary>
    [Benchmark]
    public Error CompleteFailureWorkflow()
    {
        var result = Result.Failure<string>(TestError);
        if (result.IsFailure)
        {
            return result.GetError();
        }
        throw new InvalidOperationException("Unexpected success");
    }
}
