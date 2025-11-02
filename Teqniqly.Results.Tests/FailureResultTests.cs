namespace Teqniqly.Results.Tests
{
    public class FailureResultTests
    {
        [Fact]
        public void FailureResult_WithStringError_ShouldWork()
        {
            var error = new StringError("VALIDATION_ERROR", "Invalid input");
            var result = Result.Failure<string>(error);

            Assert.False(result.IsSuccess);
            Assert.True(result.IsFailure);
            Assert.Null(result.GetValue());
            Assert.Equal(error, result.GetError());
            Assert.IsType<StringError>(result.GetError());
        }

        [Fact]
        public void FailureResult_WithIntError_ShouldWork()
        {
            var error = new IntError(400, "Bad Request");
            var result = Result.Failure<int>(error);

            Assert.False(result.IsSuccess);
            Assert.True(result.IsFailure);
            Assert.Equal(0, result.GetValue());
            Assert.Equal(error, result.GetError());
            Assert.IsType<IntError>(result.GetError());
        }

        [Fact]
        public void FailureResult_WithComplexType_ShouldWork()
        {
            var error = new StringError("COMPLEX_ERROR", "Complex error occurred");
            var result = Result.Failure<TestComplexType>(error);

            Assert.False(result.IsSuccess);
            Assert.True(result.IsFailure);
            Assert.Null(result.GetValue());
            Assert.Equal(error, result.GetError());
        }

        [Fact]
        public void FailureResult_WithIntType_ShouldReturnDefaultValue()
        {
            var error = new IntError(500, "Server error");
            var result = Result.Failure<int>(error);

            Assert.False(result.IsSuccess);
            Assert.True(result.IsFailure);
            Assert.Equal(0, result.GetValue());
            Assert.Equal(error, result.GetError());
        }

        [Fact]
        public void FailureResult_WithStringType_ShouldReturnDefaultValue()
        {
            var error = new StringError("TEST_ERROR", "Test error");
            var result = Result.Failure<string>(error);

            Assert.False(result.IsSuccess);
            Assert.True(result.IsFailure);
            Assert.Null(result.GetValue());
            Assert.Equal(error, result.GetError());
        }

        private record TestComplexType(Guid Id, string Error, int Code);
    }
}
