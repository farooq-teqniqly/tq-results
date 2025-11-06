using BenchmarkDotNet.Attributes;

namespace Teqniqly.Results.Benchmarks;

/// <summary>
/// Memory-focused benchmarks for the Result library.
/// Tests memory allocation patterns, object reuse, and GC pressure scenarios.
/// </summary>
[MemoryDiagnoser]
[SimpleJob(warmupCount: 3, iterationCount: 10)]
public class ResultMemoryBenchmarks
{
    private const int IterationCount = 1000;
    private IResult<string>[] _results = null!;

    [GlobalSetup]
    public void Setup()
    {
        _results = new IResult<string>[IterationCount];
    }

    /// <summary>
    /// Benchmarks memory allocation when storing results in an array.
    /// Tests heap allocation and array storage overhead.
    /// </summary>
    [Benchmark]
    public IResult<string>[] CreateAndStoreResultsInArray()
    {
        var results = new IResult<string>[IterationCount];
        for (int i = 0; i < IterationCount; i++)
        {
            results[i] = i % 2 == 0
                ? Result.Success($"Value {i}")
                : Result.Failure<string>(new BenchmarkError($"Error {i}"));
        }
        return results;
    }

    /// <summary>
    /// Benchmarks memory allocation when storing results in a List.
    /// Tests List growth and allocation patterns.
    /// </summary>
    [Benchmark]
    public List<IResult<int>> CreateAndStoreResultsInList()
    {
        var results = new List<IResult<int>>(IterationCount);
        for (int i = 0; i < IterationCount; i++)
        {
            results.Add(i % 2 == 0
                ? Result.Success(i)
                : Result.Failure<int>(new BenchmarkError($"Error {i}")));
        }
        return results;
    }

    /// <summary>
    /// Benchmarks memory when reusing the same success result multiple times.
    /// Tests if object reuse reduces allocations.
    /// </summary>
    [Benchmark]
    public void ReuseSuccessResult()
    {
        var successResult = Result.Success("Reused Value");
        for (int i = 0; i < IterationCount; i++)
        {
            _results[i] = successResult;
        }
    }

    /// <summary>
    /// Benchmarks memory when reusing the same error for multiple failure results.
    /// Tests error instance reuse impact.
    /// </summary>
    [Benchmark]
    public void ReuseErrorInstance()
    {
        var error = new BenchmarkError("Reused error");
        for (int i = 0; i < IterationCount; i++)
        {
            _results[i] = Result.Failure<string>(error);
        }
    }

    /// <summary>
    /// Benchmarks memory when creating new error instances for each failure.
    /// Compares against ReuseErrorInstance to show allocation difference.
    /// </summary>
    [Benchmark]
    public void CreateNewErrorInstances()
    {
        for (int i = 0; i < IterationCount; i++)
        {
            _results[i] = Result.Failure<string>(new BenchmarkError($"Error {i}"));
        }
    }

    /// <summary>
    /// Benchmarks memory when creating new value instances for each success.
    /// Tests string allocation overhead.
    /// </summary>
    [Benchmark]
    public void CreateNewValueInstances()
    {
        for (int i = 0; i < IterationCount; i++)
        {
            _results[i] = Result.Success($"Value {i}");
        }
    }

    /// <summary>
    /// Benchmarks memory for chained result operations.
    /// Simulates real-world scenario of processing results in sequence.
    /// </summary>
    [Benchmark]
    public IResult<int> ChainedResultProcessing()
    {
        IResult<int> result = Result.Success(0);
        
        for (int i = 1; i < 100; i++)
        {
            if (result.IsSuccess)
            {
                var value = result.GetValue();
                result = value < 50
                    ? Result.Success(value + i)
                    : Result.Failure<int>(new BenchmarkError($"Value exceeded: {value}"));
            }
        }
        
        return result;
    }

    /// <summary>
    /// Benchmarks memory for nested result checking patterns.
    /// Tests allocation when results contain other results.
    /// </summary>
    [Benchmark]
    public IResult<IResult<string>> NestedResults()
    {
        IResult<string> inner = Result.Success("Inner value");
        IResult<IResult<string>> outer = Result.Success(inner);
        return outer;
    }

    /// <summary>
    /// Benchmarks allocation for very large value objects in results.
    /// Tests how Result handles larger payloads.
    /// </summary>
    [Benchmark]
    public IResult<byte[]> ResultWithLargeValue()
    {
        var largeArray = new byte[10_000];
        return Result.Success(largeArray);
    }

    /// <summary>
    /// Benchmarks allocation when filtering a collection of results.
    /// Tests LINQ operation overhead with results.
    /// </summary>
    [Benchmark]
    public List<IResult<int>> FilterResults()
    {
        var results = new List<IResult<int>>();
        for (int i = 0; i < IterationCount; i++)
        {
            results.Add(i % 3 == 0
                ? Result.Success(i)
                : Result.Failure<int>(new BenchmarkError($"Error {i}")));
        }

        return results.Where(r => r.IsSuccess).ToList();
    }

    /// <summary>
    /// Benchmarks memory when results are used in dictionary keys.
    /// Tests Result equality and hashing overhead.
    /// </summary>
    [Benchmark]
    public Dictionary<string, IResult<int>> ResultsInDictionary()
    {
        var dict = new Dictionary<string, IResult<int>>();
        for (int i = 0; i < IterationCount; i++)
        {
            dict[$"key_{i}"] = i % 2 == 0
                ? Result.Success(i)
                : Result.Failure<int>(new BenchmarkError($"Error {i}"));
        }
        return dict;
    }
}
