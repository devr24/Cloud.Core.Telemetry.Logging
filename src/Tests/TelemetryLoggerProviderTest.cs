using System;
using Cloud.Core.Testing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Xunit;

namespace Cloud.Core.Telemetry.Logging.Tests
{
    public class TelemetryLoggerProviderTest
    {
        [Fact, IsUnit]
        public void Test_AddTelemetryLogger_AttachToEventHandler()
        {

            using (var logProvider = new TelemetryLoggerProvider(new TestLogger()))
            {
                logProvider.OnCreateLogger += (sender, args) => Assert.NotNull(args.Logger);
                logProvider.CreateLogger("TestLogger");
            }
        }

        [Fact, IsUnit]
        public void Test_AddTelemetryLogger_EventHandler()
        {

            using (var logProvider = new TelemetryLoggerProvider(new TestLogger()))
            {
                logProvider.CreateLogger("TestLogger");
            }
        }
        
        [Fact, IsUnit]
        public void Test_AddTelemetryLogger_NoEventHandler()
        {
            TestLogger logger = null;
            using (var logProvider = new TelemetryLoggerProvider(logger))
            {
                Assert.Null(logProvider.CreateLogger("TestLogger"));
            }
        }
    }
}
