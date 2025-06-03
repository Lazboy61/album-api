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

            // Act
            var result = _service.Greet(name);

            // Assert
            Assert.Equal("Hello Hasan", result);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void Greet_EmptyOrNull_ReturnsHelloWorld(string input)
        {
            // Act
            var result = _service.Greet(input);

            // Assert
            Assert.Equal("Hello World", result);
        }
    }
}
