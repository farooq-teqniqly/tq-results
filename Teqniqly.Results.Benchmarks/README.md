# Teqniqly.Results.Benchmarks

This project contains CPU and memory benchmarks for the Teqniqly.Results library using BenchmarkDotNet.

## Overview

The benchmarks measure the performance characteristics of the Result library across various scenarios:

### ResultCpuBenchmarks

CPU performance benchmarks focusing on execution speed:

-   **Creating Results**: Benchmarks for creating Success and Failure results with different types (string, int, Unit)
-   **Accessing Properties**: Benchmarks for checking IsSuccess and IsFailure properties
-   **Retrieving Values**: Benchmarks for calling GetValue() and GetError()
-   **Complete Workflows**: End-to-end operation benchmarks simulating real-world usage

### ResultMemoryBenchmarks

Memory allocation benchmarks focusing on real-world usage patterns and optimization opportunities:

-   **Collection Storage**: Memory impact of storing results in arrays and lists
-   **Object Reuse**: Comparing memory usage when reusing result instances vs creating new ones
-   **Error/Value Instance Reuse**: Testing allocation differences between reusing shared errors/values vs creating unique instances
-   **Chained Operations**: Memory behavior during sequential result processing
-   **Complex Scenarios**: Nested results, large payloads, LINQ operations, and dictionary storage

## Running the Benchmarks

### Quick Run

To run all benchmarks with default settings:

```bash
dotnet run -c Release --project Teqniqly.Results.Benchmarks/Teqniqly.Results.Benchmarks.csproj
```

### Run Specific Benchmark Class

To run only CPU benchmarks:

```bash
dotnet run -c Release --project Teqniqly.Results.Benchmarks/Teqniqly.Results.Benchmarks.csproj -- --filter *ResultCpuBenchmarks*
```

To run only memory benchmarks:

```bash
dotnet run -c Release --project Teqniqly.Results.Benchmarks/Teqniqly.Results.Benchmarks.csproj -- --filter *ResultMemoryBenchmarks*
```

### Run Specific Benchmark Method

To run a specific benchmark method:

```bash
dotnet run -c Release --project Teqniqly.Results.Benchmarks/Teqniqly.Results.Benchmarks.csproj -- --filter *CreateSuccessResult_String*
```

## Understanding the Results

### CPU Benchmarks

CPU benchmark results include:

-   **Mean**: Average execution time
-   **Error**: Half of 99.9% confidence interval
-   **StdDev**: Standard deviation of all measurements
-   **Allocated**: Memory allocated per operation

### Memory Benchmarks

Memory benchmark results include:

-   **Gen0**: Number of Gen 0 collections per 1000 operations
-   **Gen1**: Number of Gen 1 collections per 1000 operations
-   **Gen2**: Number of Gen 2 collections per 1000 operations
-   **Allocated**: Total memory allocated

## Benchmark Configuration

The benchmarks use the following BenchmarkDotNet configurations:

-   **MemoryDiagnoser**: Enabled on all benchmarks to track memory allocations
-   **SimpleJob** (Memory benchmarks only): 3 warmup iterations, 10 measurement iterations for consistent memory measurements

## Output

Results are saved in `BenchmarkDotNet.Artifacts` directory:

-   **results/**: Contains detailed benchmark results in various formats (HTML, Markdown, CSV)
-   **logs/**: Execution logs for debugging
-   **bin/**: Compiled benchmark executables

## Performance Considerations

When analyzing benchmark results, consider:

1. **CPU Performance**: Lower execution times indicate better performance
2. **Memory Allocations**: Fewer allocations reduce GC pressure
3. **GC Collections**: Fewer collections (especially Gen2) indicate better memory efficiency
4. **Result Type Impact**: Different generic type parameters may have different performance characteristics

## Best Practices for Running Benchmarks

1. **Close unnecessary applications** to reduce system noise
2. **Run in Release configuration** (never Debug) for accurate results
3. **Allow benchmarks to complete** without interruption
4. **Run multiple times** to verify consistency
5. **Compare relative performance** rather than absolute numbers across different machines

## Baseline Results

The following baseline results were obtained on Windows 11 with Intel Core i9-10850K CPU @ 3.60GHz running .NET 9.0.10:

### CPU Benchmarks

| Method                         |     Mean |     Error |    StdDev | Allocated |
| ------------------------------ | -------: | --------: | --------: | --------: |
| CreateSuccessResult_String     | 3.354 ns | 0.0916 ns | 0.0857 ns |      24 B |
| CreateSuccessResult_Int        | 3.575 ns | 0.1235 ns | 0.1268 ns |      24 B |
| CreateSuccessResult_Unit       | 4.108 ns | 0.0684 ns | 0.0639 ns |      24 B |
| CreateFailureResult_String     | 4.821 ns | 0.1430 ns | 0.1530 ns |      24 B |
| CreateFailureResult_Int        | 4.569 ns | 0.1169 ns | 0.1478 ns |      24 B |
| CreateFailureResult_Unit       | 4.496 ns | 0.0679 ns | 0.0636 ns |      24 B |
| GetValue_Success               | 4.488 ns | 0.0933 ns | 0.0872 ns |      24 B |
| GetError_Failure               | 4.205 ns | 0.1372 ns | 0.1525 ns |      24 B |
| CheckIsSuccess_OnSuccessResult | 4.787 ns | 0.1052 ns | 0.1252 ns |      24 B |
| CheckIsFailure_OnFailureResult | 3.738 ns | 0.0954 ns | 0.1399 ns |      24 B |
| CompleteSuccessWorkflow        | 2.696 ns | 0.1066 ns | 0.1047 ns |      24 B |
| CompleteFailureWorkflow        | 3.889 ns | 0.0772 ns | 0.0645 ns |      24 B |

**Key Takeaways:**

-   Result creation is extremely fast (3-5 nanoseconds)
-   All operations allocate exactly 24 bytes per result
-   Success results are slightly faster than failure results
-   Property checks are as fast as result creation

### Memory Benchmarks

| Method                       |          Mean |         Error |        StdDev |    Gen0 |   Gen1 | Allocated |
| ---------------------------- | ------------: | ------------: | ------------: | ------: | -----: | --------: |
| CreateAndStoreResultsInArray | 35,199.262 ns |   236.6683 ns |   123.7821 ns |  7.9956 | 1.9531 |   84024 B |
| CreateAndStoreResultsInList  | 23,057.599 ns |   117.3208 ns |    77.6005 ns |  6.1035 | 1.1902 |   64056 B |
| ReuseSuccessResult           |  5,098.665 ns |    35.8240 ns |    23.6954 ns |       - |      - |      24 B |
| ReuseErrorInstance           |  8,672.497 ns |    96.6579 ns |    57.5196 ns |  2.2888 | 0.1984 |   24024 B |
| CreateNewErrorInstances      | 37,144.894 ns |   679.4639 ns |   449.4233 ns |  8.3618 | 2.7466 |   88000 B |
| CreateNewValueInstances      | 34,255.867 ns |   276.8051 ns |   183.0895 ns |  6.1035 | 1.1597 |   64000 B |
| ChainedResultProcessing      |    121.482 ns |     1.6364 ns |     1.0823 ns |  0.0358 |      - |     376 B |
| NestedResults                |      7.282 ns |     0.2366 ns |     0.1565 ns |  0.0046 |      - |      48 B |
| ResultWithLargeValue         |    371.293 ns |    31.7851 ns |    21.0239 ns |  0.9613 |      - |   10048 B |
| FilterResults                | 33,578.385 ns | 1,431.4501 ns |   946.8156 ns |  8.1787 | 2.0142 |   86024 B |
| ResultsInDictionary          | 71,889.915 ns | 1,825.1418 ns | 1,207.2183 ns | 18.7988 | 9.2773 |  198136 B |

**Key Takeaways:**

-   **Object Reuse is Highly Effective**: Reusing result instances reduces allocations from 88KB to 24B (3,666x reduction)
-   **Lists vs Arrays**: Lists are ~35% faster than arrays for storing results with ~24% less memory
-   **Error Reuse**: Reusing error instances saves ~73% memory compared to creating unique errors
-   **Chained Operations**: Processing 100 chained results allocates only 376 bytes
-   **LINQ Impact**: Filtering operations have moderate overhead but reasonable allocations
-   **Gen1 Collections**: Occur under heavy allocation scenarios (arrays, dictionaries)

## Contributing New Benchmarks

When adding new benchmarks:

1. Add methods to existing benchmark classes or create new ones
2. Use `[Benchmark]` attribute on benchmark methods
3. Include XML documentation explaining what is being measured
4. Use descriptive method names (underscores are allowed for readability)
5. Follow the existing naming patterns for consistency
