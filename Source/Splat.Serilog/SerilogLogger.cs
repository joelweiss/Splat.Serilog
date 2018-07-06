namespace Splat.Serilog
{
    /// <summary>
    /// Serilog adapter for Splat
    /// </summary>
    /// <seealso cref="Splat.ILogger" />
    public class SerilogLogger : Splat.ILogger
    {
        private readonly global::Serilog.ILogger _Logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="SerilogLogger"/> class.
        /// </summary>
        /// <param name="logger">The Serilog logger.</param>
        public SerilogLogger(global::Serilog.ILogger logger)
        {
            _Logger = logger;
        }

        Splat.LogLevel Splat.ILogger.Level { get; set; }

        void Splat.ILogger.Write(string message, Splat.LogLevel logLevel)
        {
            switch (logLevel)
            {
                case Splat.LogLevel.Debug:
                    _Logger.Debug(message);
                    break;
                case Splat.LogLevel.Error:
                    _Logger.Error(message);
                    break;
                case Splat.LogLevel.Fatal:
                    _Logger.Fatal(message);
                    break;
                case Splat.LogLevel.Info:
                    _Logger.Information(message);
                    break;
                case Splat.LogLevel.Warn:
                    _Logger.Warning(message);
                    break;
                default:
                    _Logger.Information(message);
                    break;
            }
        }
    }
}
