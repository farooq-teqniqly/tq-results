namespace Teqniqly.Results.Tests
{
  public class FailureResultTests
  {
    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void FailureResult_WithBool_ShouldWork(bool value) => TestFailureResult(value);

    [Fact]
    public void FailureResult_WithComplexType_ShouldWork() =>
      TestFailureResult(
        new
        {
          Id = Guid.NewGuid(),
          Error = "Something went wrong",
          Code = 50001,
        }
      );

    [Theory]
    [InlineData(42)]
    [InlineData(-1)]
    [InlineData(0)]
    public void FailureResult_WithInt_ShouldWork(int value) => TestFailureResult(value);

    [Theory]
    [InlineData("Hello")]
    [InlineData("")]
    [InlineData("World")]
    public void FailureResult_WithString_ShouldWork(string value) => TestFailureResult(value);

    private static void TestFailureResult<T>(T expectedValue)
    {
      var result = Result.Failure(expectedValue);

      Assert.False(result.IsSuccess);
      Assert.True(result.IsFailure);
      Assert.Equal(expectedValue, result.GetValue());
    }
  }
}
