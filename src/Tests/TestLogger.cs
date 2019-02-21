using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Logging;

namespace Cloud.Core.Telemetry.Logging.Tests
{

    public class TestLogger : ITelemetryLogger
    {
        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public void Flush()
        {
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
        }

        public void LogCritical(string message, Dictionary<string, string> properties = null, [CallerMemberName] string callerMemberName = "", [CallerFilePath] string callerFilePath = "", [CallerLineNumber] int callerLineNumber = -1)
        {
        }

        public void LogCritical(Exception ex, Dictionary<string, string> properties = null, [CallerMemberName] string callerMemberName = "", [CallerFilePath] string callerFilePath = "", [CallerLineNumber] int callerLineNumber = -1)
        {
        }

        public void LogError(string message, Dictionary<string, string> properties = null, [CallerMemberName] string callerMemberName = "", [CallerFilePath] string callerFilePath = "", [CallerLineNumber] int callerLineNumber = -1)
        {
        }

        public void LogError(Exception ex, Dictionary<string, string> properties = null, [CallerMemberName] string callerMemberName = "", [CallerFilePath] string callerFilePath = "", [CallerLineNumber] int callerLineNumber = -1)
        {
        }

        public void LogInformation(string message, Dictionary<string, string> properties = null, [CallerMemberName] string callerMemberName = "", [CallerFilePath] string callerFilePath = "", [CallerLineNumber] int callerLineNumber = -1)
        {
        }

        public void LogMetric(string metricName, double metricValue, [CallerMemberName] string callerMemberName = "", [CallerFilePath] string callerFilePath = "", [CallerLineNumber] int callerLineNumber = -1)
        {
        }

        public void LogVerbose(string message, Dictionary<string, string> properties = null, [CallerMemberName] string callerMemberName = "", [CallerFilePath] string callerFilePath = "", [CallerLineNumber] int callerLineNumber = -1)
        {
        }

        public void LogWarning(string message, Dictionary<string, string> properties = null, [CallerMemberName] string callerMemberName = "", [CallerFilePath] string callerFilePath = "", [CallerLineNumber] int callerLineNumber = -1)
        {
        }

        public void LogWarning(Exception ex, Dictionary<string, string> properties = null, [CallerMemberName] string callerMemberName = "", [CallerFilePath] string callerFilePath = "", [CallerLineNumber] int callerLineNumber = -1)
        {
        }
    }
}
