namespace Cloud.Core.Telemetry.Logging
{
    using System;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// Logging provider can be used to attach loggers to service collections.
    /// </summary>
    /// <seealso cref="Microsoft.Extensions.Logging.ILoggerProvider" />
    public class TelemetryLoggerProvider : ILoggerProvider
    {
        private readonly ITelemetryLogger _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryLoggerProvider"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        public TelemetryLoggerProvider(ITelemetryLogger logger)
        {
            _logger = logger;
        }
        
        /// <summary>
        /// Creates a new <see cref="T:Microsoft.Extensions.Logging.ILogger" /> instance.
        /// </summary>
        /// <param name="categoryName">The category name for messages produced by the logger.</param>
        /// <returns></returns>
        public ILogger CreateLogger(string categoryName)
        {
            //TelemetryLogger customLogger = Loggers.GetOrAdd(categoryName, new TelemetryLogger(this));
            OnCreateLogger?.Invoke(this, new TelemetryLoggerEventArgs(_logger));
            return _logger;
        }

        /// <summary>
        /// Occurs when [on create logger].
        /// </summary>
        public event EventHandler<TelemetryLoggerEventArgs> OnCreateLogger;

        /// <inheritdoc />
        /// <summary>
        /// Performs specific tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
        }
    }
}
