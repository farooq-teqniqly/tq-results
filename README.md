# Teqniqly.Results

[![NuGet](https://img.shields.io/nuget/v/Teqniqly.Results)](https://www.nuget.org/packages/Teqniqly.Results)
[![Build and Test](https://github.com/farooq-teqniqly/tq-results/workflows/Deploy%20to%20NuGet/badge.svg)](https://github.com/farooq-teqniqly/tq-results/actions)
[![Nightly Performance Benchmarks](https://github.com/farooq-teqniqly/tq-results/workflows/Nightly%20Performance%20Benchmarks/badge.svg)](https://github.com/farooq-teqniqly/tq-results/actions)
[![.NET 8](https://img.shields.io/badge/.NET-8.0-blue)](https://dotnet.microsoft.com/download/dotnet/8.0)
[![.NET 9](https://img.shields.io/badge/.NET-9.0-blue)](https://dotnet.microsoft.com/download/dotnet/9.0)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=farooq-teqniqly_tq-results&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=farooq-teqniqly_tq-results)

A lightweight, type-safe Result pattern library for C# that eliminates the need for exceptions in control flow and provides explicit error handling.

## Table of Contents

-   [Teqniqly.Results](#teqniqlyresults)
    -   [Table of Contents](#table-of-contents)
    -   [The Problem](#the-problem)
    -   [The Solution](#the-solution)
    -   [Getting Started](#getting-started)
        -   [Installation](#installation)
        -   [Basic Usage](#basic-usage)
        -   [Advanced Usage](#advanced-usage)
    -   [Samples](#samples)
    -   [Running Tests](#running-tests)
    -   [Key Types](#key-types)
    -   [Benefits](#benefits)
    -   [Design Principles](#design-principles)
    -   [API Reference](#api-reference)

## The Problem

Traditional error handling in C# often relies on exceptions, which can be problematic for control flow:

-   **Performance**: Exceptions are expensive and should be reserved for truly exceptional circumstances
-   **Clarity**: Method signatures don't indicate possible failure modes
-   **Type Safety**: Callers can forget to handle errors, leading to runtime exceptions
-   **Debugging**: Exception stack traces can obscure the actual business logic flow

## The Solution

Teqniqly.Results provides a `Result<T>` type that makes errors explicit in your method signatures and return types. Instead of throwing exceptions, methods return a `Result<T>` that can represent either success with a value or failure with an error.

```csharp
// Traditional approach - exceptions for control flow
public User GetUser(int id)
{
    var user = _repository.GetById(id);

    if (user == null)
    {
        throw new UserNotFoundException($"User {id} not found");
    }

    return user;
}

// Result pattern - explicit error handling
public IResult<User> GetUser(int id)
{
    var user = _repository.GetById(id);

    if (user == null)
    {
        return Result.Failure<User>(new UserNotFoundError($"User {id} not found"));
    }

    return Result.Success(user);
}
```

## Getting Started

### Installation

Add the library to your project:

```bash
dotnet add package Teqniqly.Results --prerelease
```

Or reference the project directly in your solution.

### Basic Usage

1. **Create custom error types** by inheriting from `Error`:

```csharp
public sealed record UserNotFoundError(string Message, int UserId) : Error(Message);
public sealed record ValidationError(string Message, string Field) : Error(Message);
```

1. **Return results** from your methods:

```csharp
public IResult<User> CreateUser(CreateUserRequest request)
{
    if (string.IsNullOrEmpty(request.Email))
    {
        return Result.Failure<User>(new ValidationError("Email is required", "Email"));
    }

    var user = new User { Email = request.Email, Name = request.Name };
    _repository.Save(user);

    return Result.Success(user);
}
```

1. **Handle results** in your calling code:

```csharp
var result = userService.CreateUser(request);

if (result.IsSuccess)
{
    var user = result.GetValue();
    // Handle success case
}
else
{
    var error = result.GetError();
    // Handle error case - error is guaranteed to be non-null
}
```

### Advanced Usage

Use pattern matching for clean error handling:

```csharp
return result.GetError() switch
{
    ValidationError validationError => BadRequest(validationError.Message),
    UserNotFoundError notFoundError => NotFound(notFoundError.Message),
    _ => StatusCode(500, "An unexpected error occurred")
};
```

## Samples

Explore the included samples to see the library in action:

-   **[WebApiSample](samples/WebApiSample/README.md)**: A complete ASP.NET Core Web API demonstrating the Result pattern with proper HTTP status code mapping and custom error types.

## Running Tests

The library includes comprehensive tests that demonstrate usage patterns and ensure correctness. Run the tests to see examples of how to use all features:

```bash
# Run all tests
dotnet test

# Run tests for a specific project
dotnet test Teqniqly.Results.Tests/Teqniqly.Results.Tests.csproj

# Run tests with detailed output
dotnet test --verbosity normal
```

The tests cover:

-   Success and failure result creation
-   Type safety with generic results
-   Error handling patterns
-   Complex type support

## Performance Benchmarks

The library includes comprehensive CPU and memory benchmarks to measure performance characteristics.

**Quick Performance Highlights:**

-   ⚡ **Ultra-fast**: Result creation takes only 7-9 nanoseconds
-   💾 **Low allocation**: Each result allocates exactly 24 bytes
-   ♻️ **Reuse benefits**: Reusing result instances reduces allocations by 3,667x (88KB → 24B)
-   📦 **Collection-friendly**: Lists are ~31% faster than arrays for storing results

See the **[Benchmarks README](Teqniqly.Results.Benchmarks/README.md)** for detailed baseline results and information on:

-   Running benchmarks
-   Understanding results
-   CPU performance measurements
-   Memory allocation analysis
-   Optimization opportunities

## Key Types

-   **`IResult<T>`**: The core interface representing an operation result
-   **`Error`**: Abstract base record for all error types
-   **`Result`**: Static factory class for creating success/failure results
-   **`Unit`**: A unit type for operations that don't return meaningful data

## Benefits

-   **Type Safety**: Errors are part of the return type, impossible to ignore
-   **Performance**: No exception overhead for expected failure cases
-   **Clarity**: Method signatures clearly indicate possible failure modes
-   **Composability**: Results work well with LINQ and functional programming patterns
-   **Testability**: Easy to test both success and failure scenarios

## Design Principles

-   **Minimal API**: Simple, focused interface that's easy to learn
-   **Type Safe**: Leverages C#'s type system for correctness
-   **Performance Conscious**: No allocations in success paths for value types
-   **Extensible**: Easy to create custom error types for your domain
-   **Framework Agnostic**: Works with any .NET application, not tied to ASP.NET Core

## API Reference

All types include comprehensive XML documentation. In Visual Studio, use IntelliSense or generate documentation with:

```bash
dotnet build --configuration Release
```

This will generate XML documentation files alongside the assemblies.
