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

The following baseline results were obtained on Azure VM Standard B2als v2 (2 vCPUs, 4 GiB memory) running .NET 9.0:

### CPU Benchmarks

| Method                         |     Mean | Allocated |
| ------------------------------ | -------: | --------: |
| CreateSuccessResult_String     |  7.480 ns |      24 B |
| CreateSuccessResult_Int        |  7.442 ns |      24 B |
| CreateSuccessResult_Unit       |  7.847 ns |      24 B |
| CreateFailureResult_String     |  9.418 ns |      24 B |
| CreateFailureResult_Int        |  9.047 ns |      24 B |
| CreateFailureResult_Unit       |  9.045 ns |      24 B |
| GetValue_Success               |  8.979 ns |      24 B |
| GetError_Failure               |  8.772 ns |      24 B |
| CheckIsSuccess_OnSuccessResult |  8.816 ns |      24 B |
| CheckIsFailure_OnFailureResult |  6.901 ns |      24 B |
| CompleteSuccessWorkflow        |  7.006 ns |      24 B |
| CompleteFailureWorkflow        |  8.477 ns |      24 B |

**Key Takeaways:**

-   Result creation is extremely fast (7-9 nanoseconds)
-   All operations allocate exactly 24 bytes per result
-   Success results are slightly faster than failure results
-   Property checks are as fast as result creation

### Memory Benchmarks

| Method                       |          Mean |    Gen0 |   Gen1 | Allocated |
| ---------------------------- | ------------: | ------: | -----: | --------: |
| CreateAndStoreResultsInArray | 52,143.810 ns | 14.4231 | 2.9264 |   84024 B |
| CreateAndStoreResultsInList  | 35,515.440 ns | 20.6720 | 0.2074 |   64056 B |
| ReuseSuccessResult           |  6,559.560 ns |       - |      - |      24 B |
| ReuseErrorInstance           | 14,737.000 ns |  9.1851 | 0.0294 |   24024 B |
| CreateNewErrorInstances      | 55,423.150 ns | 15.6250 | 3.5461 |   88000 B |
| CreateNewValueInstances      | 47,325.480 ns |  9.9566 | 1.4787 |   64000 B |
| ChainedResultProcessing      |    198.940 ns |  0.0732 |      - |     376 B |
| NestedResults                |     14.120 ns |  0.0089 |      - |      48 B |
| ResultWithLargeValue         |    690.190 ns |  3.8307 |      - |   10048 B |
| FilterResults                | 48,246.960 ns | 15.0696 | 2.8980 |   86024 B |
| ResultsInDictionary          | 98,298.110 ns | 30.7571 | 7.4921 |  198136 B |

**Key Takeaways:**

-   **Object Reuse is Highly Effective**: Reusing result instances reduces allocations from 88KB to 24B (3,667x reduction)
-   **Lists vs Arrays**: Lists are ~31% faster than arrays for storing results with ~24% less memory
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
