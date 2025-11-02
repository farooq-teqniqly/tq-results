namespace Teqniqly.Results.Tests
{
  public class SuccessResultTests
  {
    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void SuccessResult_WithBool_ShouldWork(bool value) => TestSuccessResult(value);

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
    public void SuccessResult_WithComplexType_ShouldWork() =>
      TestSuccessResult(
        new
        {
          Id = Guid.NewGuid(),
          Name = "Foo",
          CreatedAt = DateTimeOffset.UtcNow,
        }
      );

    private static void TestSuccessResult<T>(T expectedValue)
    {
      var result = Result.Success(expectedValue);

      Assert.True(result.IsSuccess);
      Assert.False(result.IsFailure);
      Assert.Equal(expectedValue, result.GetValue());
    }
  }
}
