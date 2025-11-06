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

## Contributing New Benchmarks

When adding new benchmarks:

1. Add methods to existing benchmark classes or create new ones
2. Use `[Benchmark]` attribute on benchmark methods
3. Include XML documentation explaining what is being measured
4. Use descriptive method names (underscores are allowed for readability)
5. Follow the existing naming patterns for consistency
