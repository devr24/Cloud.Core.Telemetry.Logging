using Cloud.Core.Testing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Xunit;

namespace Cloud.Core.Telemetry.Logging.Tests
{
    [IsUnit]
    public class LoggingBuilderExtensionsTest
    {
        /// <summary>Verify the Add Telemetry Logger adds an ITelemetryLogger as expected.</summary>
        [Fact]
        public void Test_AddTelemetryLogger_Positive()
        {
            // Arrange
            var services = new ServiceCollection();

            // Act
            services.AddLogging(loggers => { 
                loggers.AddTelemetryLogger(new FakeTelemetryLogger());
            });

            var serviceProvider = services.BuildServiceProvider();

            // Assert
            Assert.NotNull(serviceProvider.GetService<ILogger<LoggingBuilderExtensionsTest>>());
        }

        /// <summary>Ensure that no logger is found when the provider was not used.</summary>
        [Fact]
        public void Test_AddTelemetryLogger_Negative()
        {
            // Arrange
            var serviceProvider = new ServiceCollection().BuildServiceProvider();

            // Act/Assert
            Assert.Null(serviceProvider.GetService<ILogger<LoggingBuilderExtensionsTest>>());
        }
    }
}
