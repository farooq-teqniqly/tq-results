using System.Diagnostics.CodeAnalysis;

// Benchmark methods with underscores for readability are acceptable
[assembly: SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "Underscores improve benchmark method name readability")]

// Benchmark classes must be public for BenchmarkDotNet to discover them
[assembly: SuppressMessage("Design", "CA1515:Consider making public types internal", Justification = "Benchmark classes must be public for BenchmarkDotNet")]

// Benchmark methods must be instance methods, not static
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Benchmark methods must be instance methods for BenchmarkDotNet")]

// List<T> is appropriate for benchmark methods measuring collection performance
[assembly: SuppressMessage("Design", "CA1002:Do not expose generic lists", Justification = "List<T> is appropriate for benchmarks measuring collection operations")]
