using BenchmarkDotNet.Running;
using Teqniqly.Results.Benchmarks;

// Run all benchmarks
BenchmarkRunner.Run<ResultCpuBenchmarks>();
BenchmarkRunner.Run<ResultMemoryBenchmarks>();
