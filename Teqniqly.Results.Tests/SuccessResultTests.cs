namespace Teqniqly.Results.Tests
{
  public class SuccessResultTests
  {
    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void SuccessResult_WithBool_ShouldWork(bool value) => TestSuccessResult(value);

    [Fact]
    public void SuccessResult_WithComplexType_Should_Work()
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

    private static void TestSuccessResult<T>(T expectedValue)
    {
      var result = new SuccessResult<T>(expectedValue);

      Assert.True(result.IsSuccess);
      Assert.False(result.IsFailure);
      Assert.Null(result.GetError());
      Assert.Equal(expectedValue, result.GetValue());
    }
  }
}
