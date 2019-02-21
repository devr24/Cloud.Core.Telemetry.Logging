namespace Microsoft.Extensions.Logging
{
    using Cloud.Core;
    using Cloud.Core.Telemetry.Logging;
    using DependencyInjection;

    /// <summary>
    /// Telemetry logger factory adds the AddTelemetryLogger method to the ILoggingBuilder.
    /// </summary>
    public static class LoggingBuilderExtensions
    {
        /// <summary>
        /// Adds the telemetry logger factory method to the logging builder.
        /// </summary>
        /// <param name="builder">The builder to add to.</param>
        /// <param name="instance">The instance to add.</param>
        /// <returns>The modified builder.</returns>
        public static ILoggingBuilder AddTelemetryLogger(this ILoggingBuilder builder, ITelemetryLogger instance)
        {
            builder.Services.AddSingleton(instance);
            builder.Services.AddSingleton<ILoggerProvider>(a => new TelemetryLoggerProvider(a.GetService<ITelemetryLogger>()));
            return builder;
        }
    }
}
