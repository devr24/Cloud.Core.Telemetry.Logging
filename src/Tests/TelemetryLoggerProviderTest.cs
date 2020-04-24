using Cloud.Core.Testing;
using Xunit;

namespace Cloud.Core.Telemetry.Logging.Tests
{
    [IsUnit]
    public class TelemetryLoggerProviderTest
    {
        /// <summary>Ensure event handler is triggered when create logger is fired.</summary>
        [Fact]
        public void Test_AddTelemetryLogger_AttachToEventHandler()
        {
            // Arrange
            using var logProvider = new TelemetryLoggerProvider(new FakeTelemetryLogger());
            
            // Act/Assert
            logProvider.OnCreateLogger += (sender, args) => Assert.NotNull(args.Logger);
            logProvider.CreateLogger("TestLogger");
        }

        /// <summary>Ensure create logger returns the injected logger.</summary>
        [Fact]
        public void Test_AddTelemetryLogger_EventHandler()
        {
            // Arrange
            using var logProvider = new TelemetryLoggerProvider(new FakeTelemetryLogger());
            
            // Act/Assert
            Assert.NotNull(logProvider.CreateLogger("TestLogger"));
        }

        /// <summary>Ensure create logger returns null when no logger has been setup.</summary>
        [Fact]
        public void Test_AddTelemetryLogger_NoEventHandler()
        {
            // Arrange
            FakeTelemetryLogger logger = null;
            using var logProvider = new TelemetryLoggerProvider(logger);
            
            // Act/Assert
            Assert.Null(logProvider.CreateLogger("TestLogger"));
        }
    }
}
