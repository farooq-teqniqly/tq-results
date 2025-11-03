namespace Teqniqly.Results.Tests
{
    public class SuccessResultTests
    {
        [Fact]
        public void SuccessResult_When_Value_Null_Throws_Exception()
        {
            Assert.Throws<ArgumentNullException>(() => Result.Success((string)null!));
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void SuccessResult_WithBool_ShouldWork(bool value) => TestSuccessResult(value);

        [Fact]
        public void SuccessResult_WithComplexType_ShouldWork()
        {
            var value = new
            {
                Id = Guid.NewGuid(),
                Name = "Teqniqly",
                CreatedAt = DateTimeOffset.UtcNow,
            };
            TestSuccessResult(value);
        }

        [Theory]
        [InlineData(42)]
        [InlineData(-1)]
        [InlineData(0)]
        public void SuccessResult_WithInt_ShouldWork(int value) => TestSuccessResult(value);

        [Theory]
        [InlineData("Hello")]
        [InlineData("")]
        [InlineData("World")]
        public void SuccessResult_WithString_ShouldWork(string value) => TestSuccessResult(value);

        [Fact]
        public void SuccessResult_WithUnit_ShouldWork() => TestSuccessResult(Unit.Value);

        private static void TestSuccessResult<T>(T expectedValue)
        {
            var result = Result.Success(expectedValue);

            Assert.True(result.IsSuccess);
            Assert.False(result.IsFailure);

            var exception = Assert.Throws<InvalidOperationException>(() => result.GetError());

            Assert.Contains(
                "Cannot retrieve an error from a successful result",
                exception.Message,
                StringComparison.OrdinalIgnoreCase
            );

            Assert.Equal(expectedValue, result.GetValue());
        }
    }
}
