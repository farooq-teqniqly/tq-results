using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teqniqly.Results.Tests
{
    public class FailureResultTests
    {
        private sealed record TestError(string Message) : Error(Message);

        [Fact]
        public void FailureResult_WithBool_ShouldWork() => TestFailureResult<bool>();

        [Fact]
        public void FailureResult_WithComplexType_Should_Work() => TestFailureResult<dynamic>();

        [Fact]
        public void FailureResult_WithInt_ShouldWork() => TestFailureResult<int>();

        [Fact]
        public void FailureResult_WithString_ShouldWork() => TestFailureResult<string>();

        [Fact]
        public void FailureResult_WithUnit_Should_Work() => TestFailureResult<Unit>();

        [Fact]
        public void FailuresResult_When_Error_Null_Throws_Exception()
        {
            Assert.Throws<ArgumentNullException>(() => Result.Failure<string>(null!));
        }

        private static void TestFailureResult<T>()
        {
            var result = Result.Failure<T>(new TestError("ERROR"));

            Assert.False(result.IsSuccess);
            Assert.True(result.IsFailure);

            var exception = Assert.Throws<InvalidOperationException>(() => result.GetValue());

            Assert.Contains(
                "Cannot retrieve a value from a failure result",
                exception.Message,
                StringComparison.OrdinalIgnoreCase
            );
        }
    }
}
