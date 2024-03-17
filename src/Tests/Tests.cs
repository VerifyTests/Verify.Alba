public class Tests
{
    [Fact]
    public async Task IgnoreHeader()
    {
        await using var host = await AlbaHost.For<Program>();

        // This runs an HTTP request and makes an assertion
        // about the expected content of the response
        var result = await host.Scenario(
            _ =>
            {
                _.Get.Url("/weatherforecast");
                _.Get.Url("/weatherforecast");
            });

        await Verify(result.Context);
    }
}