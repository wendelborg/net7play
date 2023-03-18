namespace Net7.UnitTests;

public class WeatherForecastTests
{
    [Test]
    public void ConvertsToFahrenheit()
    {
        var forecast = new WeatherForecast
        {
            TemperatureC = 33
        };

        Assert.That(forecast.TemperatureF, Is.EqualTo(91));
    }
}