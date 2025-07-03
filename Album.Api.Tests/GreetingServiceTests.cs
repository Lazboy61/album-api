using Album.Api.Services;
using Xunit;

namespace Album.Api.Tests
{
    public class GreetingServiceTests
    {
        private readonly GreetingService _service = new GreetingService();

        [Fact]
        public void Greet_WithName_ReturnsHelloName()
        {
            // Arrange
            var name = "Hasan";
            var hostname = System.Net.Dns.GetHostName();

            // Act
            var result = _service.Greet(name);

            // Assert
            Assert.Equal($"Hello Hasan from {hostname} v2", result);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void Greet_EmptyOrNull_ReturnsHelloWorld(string input)
        {
            // Arrange
            var hostname = System.Net.Dns.GetHostName();

            // Act
            var result = _service.Greet(input);

            // Assert
            Assert.Equal($"Hello World from {hostname} v2", result);
        }
    }
}