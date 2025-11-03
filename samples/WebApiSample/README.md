# Teqniqly.Results WebApi Sample

This sample demonstrates how to use the `Teqniqly.Results` library in an ASP.NET Core Web API application. It shows a practical implementation of the Result pattern for handling operation outcomes in a clean, type-safe way.

## Overview

The sample implements a simple weather forecast API that returns weather data for a given city. It demonstrates:

- Creating custom error types that inherit from `Error`
- Using `Result.Success<T>()` and `Result.Failure<T>()` to return operation outcomes
- Handling results in ASP.NET Core controllers with appropriate HTTP status codes
- Type-safe error handling without exceptions

## API Endpoints

### GET /WeatherForecast/{city}

Returns weather forecast data for the specified city.

**Example Request:**
```
GET /WeatherForecast/Seattle
```

**Example Success Response (200 OK):**
```json
[
  {
    "date": "2025-11-03",
    "temperatureC": 15,
    "summary": "Mild",
    "temperatureF": 59
  },
  {
    "date": "2025-11-04",
    "temperatureC": 22,
    "summary": "Warm",
    "temperatureF": 71
  }
]
```

**Example Error Response (404 Not Found):**
```json
{
  "type": "https://tools.ietf.org/html/rfc9110#section-15.5.5",
  "title": "Not Found",
  "status": 404,
  "detail": "City not found"
}
```

## Key Implementation Details

### 1. Custom Error Types

The sample defines a custom error type for city not found scenarios:

```csharp
internal sealed record CityNotFoundError(string Message, string City) : Error(Message);
```

This inherits from the base `Error` record and adds city-specific information.

### 2. Service Layer with Result Pattern

The `WeatherForecastService` demonstrates how to use the Result pattern in business logic:

```csharp
internal static IResult<IEnumerable<WeatherForecast>> GetWeatherForecast(string city)
{
    if (!ValidCities.Contains(city, StringComparer.OrdinalIgnoreCase))
    {
        return Result.Failure<IEnumerable<WeatherForecast>>(
            new CityNotFoundError("City not found", city)
        );
    }

    var forecasts = /* generate forecast data */;
    return Result.Success(forecasts);
}
```

### 3. Controller Result Handling

The controller shows how to handle results and map them to appropriate HTTP responses:

```csharp
public ActionResult<IEnumerable<WeatherForecast>> Get([FromRoute] string city)
{
    var result = WeatherForecastService.GetWeatherForecast(city);

    if (!result.IsFailure)
    {
        return Ok(result.GetValue());
    }

    var error = result.GetError();

    return error switch
    {
        CityNotFoundError => Problem(
            error.Message,
            statusCode: StatusCodes.Status404NotFound
        ),
        _ => Problem(error.Message, statusCode: StatusCodes.Status400BadRequest),
    };
}
```

## Running the Sample

1. Ensure you have the .NET SDK installed
2. Navigate to the `samples/WebApiSample` directory
3. Run the application:
   ```bash
   dotnet run
   ```
4. The API will be available at `https://localhost:5001` (or similar, check the console output)
5. Test the endpoints using the provided `WebApiSample.http` file or tools like Postman/curl

## Testing with the HTTP File

The sample includes a `WebApiSample.http` file that you can use with VS Code's REST Client extension or similar tools to test the API:

```http
GET https://localhost:5001/WeatherForecast/Seattle

GET https://localhost:5001/WeatherForecast/InvalidCity
```

## Benefits of Using Teqniqly.Results

1. **Type Safety**: Results are strongly typed, preventing runtime errors
2. **Explicit Error Handling**: Errors are part of the return type, making them impossible to ignore
3. **No Exceptions for Flow Control**: Use results instead of exceptions for expected failure cases
4. **Clean API Design**: Controllers can focus on HTTP concerns while services handle business logic
5. **Pattern Matching**: Easy to use C# pattern matching for different error types

## Extending the Sample

You can extend this sample by:

- Adding more custom error types for different failure scenarios
- Implementing additional endpoints that use the Result pattern
- Adding validation and returning validation errors as results
- Using the `Unit` type for operations that don't return data

## Learn More

For more information about the Teqniqly.Results library, see the main project documentation and XML documentation comments on the types.
