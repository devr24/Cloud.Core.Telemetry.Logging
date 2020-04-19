using Cloud.Core.Testing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Xunit;

namespace Cloud.Core.Telemetry.Logging.Tests
{
    [IsUnit]
    public class LoggingBuilderExtensionsTest
    {
        [Fact]
        public void Test_AddTelemetryLogger_Positive()
        {
            var services = new ServiceCollection();

            services.AddLogging(loggers => { 
                loggers.AddTelemetryLogger(new TestLogger());
            });

            var serviceProvider = services.BuildServiceProvider();
            Assert.NotNull(serviceProvider.GetService<ILogger<LoggingBuilderExtensionsTest>>());
        }

        [Fact]
        public void Test_AddTelemetryLogger_Negative()
        {
            var serviceProvider = new ServiceCollection().BuildServiceProvider();
            Assert.Null(serviceProvider.GetService<ILogger<LoggingBuilderExtensionsTest>>());
        }
    }
}
