using Microsoft.Extensions.Configuration;

namespace Net7.ComponentTests;

public class WeatherForecastTests
{
    private ComponentTestConfig TestConfig { get; set; } = new ComponentTestConfig();

    [OneTimeSetUp]
    public void OneTimeSetup()
    {
        TestConfig = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", false, false)
            .AddEnvironmentVariables()
            .Build()
            .GetSection("ComponentTests")
            .Get<ComponentTestConfig>() ?? new ComponentTestConfig();
    }

    [Test]
    public void Uses_correct_URI()
    {
        Assert.That(TestConfig.ServiceUri, Is.EqualTo("http://localhost:8080"));
    }
        
    [Test]
    public async Task Can_fetch_from_API()
    {
        // Arrange
        var httpClient = new HttpClient { BaseAddress = new Uri(TestConfig.ServiceUri) };


        // Act
        var response = await httpClient.GetAsync("/WeatherForecast");
        var statusCode = response.IsSuccessStatusCode;

        // Assert
        Assert.That(statusCode, Is.True);
    }
}

public class ComponentTestConfig
{
    public string ServiceUri { get; set; } = string.Empty;
}
