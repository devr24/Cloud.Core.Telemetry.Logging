namespace Cloud.Core.Telemetry.Logging
{
    /// <summary>
    /// Event args for Telemetry logger.
    /// </summary>
    public class TelemetryLoggerEventArgs
    {
        /// <summary>
        /// Gets the logger instance.
        /// </summary>
        /// <value>
        /// The logger.
        /// </value>
        public ITelemetryLogger Logger { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryLoggerEventArgs"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        public TelemetryLoggerEventArgs(ITelemetryLogger logger)
        {
            Logger = logger;
        }
    }
}
