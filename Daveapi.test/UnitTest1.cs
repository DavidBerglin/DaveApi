using DaveApi;

namespace Daveapi.test
{
    public class UnitTest1
    {
        [Fact]
        public void Temperature_ShouldBeInValidRange()
        {
            // Arrange
            var forecast = new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now),
                TemperatureC = 25,
                Summary = "Warm"
            };

            // Act & Assert
            Assert.InRange(forecast.TemperatureC, -50, 50);
        }

        [Fact]
        public void TemperatureF_ShouldConvertCorrectly()
        {
            // Arrange
            var forecast = new WeatherForecast
            {
                TemperatureC = 0
            };

            // Act
            var tempF = forecast.TemperatureF;

            // Assert
            Assert.Equal(32, tempF);
        }
       /* [Fact]
        public void Temperature_ShouldAlwaysFail()
        {
            // Arrange
            var forecast = new WeatherForecast
            {
                TemperatureC = 25
            };

            // Act & Assert
            Assert.True(false, "Detta test är designat att faila!");
        }

        */
    }
}

