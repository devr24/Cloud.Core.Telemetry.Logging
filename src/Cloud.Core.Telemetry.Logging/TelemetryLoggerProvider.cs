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
        internal bool Disposed;

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
            OnCreateLogger?.Invoke(this, new TelemetryLoggerEventArgs(_logger));
            return _logger;
        }

        /// <summary>
        /// Occurs when [on create logger].
        /// </summary>
        public event EventHandler<TelemetryLoggerEventArgs> OnCreateLogger;

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            // Dispose of unmanaged resources.
            Dispose(true);

            // Suppress finalization.
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (Disposed)
            {
                return;
            }

            if (disposing)
            {
                // custom dispose code here...
            }

            Disposed = true;
        }
    }
}
