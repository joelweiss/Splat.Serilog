#pragma warning disable Serilog004 // Constant MessageTemplate verifier
using System;
using Serilog.Events;

namespace Splat.Serilog
{
    /// <summary>
    /// Serilog adapter for Splat
    /// </summary>
    /// <seealso cref="Splat.ILogger" />
    public class SerilogLogger : Splat.IFullLogger
    {
        private readonly global::Serilog.ILogger _Logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="SerilogLogger"/> class.
        /// </summary>
        /// <param name="logger">The Serilog logger.</param>
        public SerilogLogger(global::Serilog.ILogger logger) => _Logger = logger;

        LogLevel ILogger.Level { get; set; }
        public bool IsDebugEnabled => _Logger.IsEnabled(LogEventLevel.Debug);
        public bool IsInfoEnabled => _Logger.IsEnabled(LogEventLevel.Information);
        public bool IsWarnEnabled => _Logger.IsEnabled(LogEventLevel.Warning);
        public bool IsErrorEnabled => _Logger.IsEnabled(LogEventLevel.Error);
        public bool IsFatalEnabled => _Logger.IsEnabled(LogEventLevel.Fatal);

        void IFullLogger.Debug<T>(T value) => _Logger.Debug(value?.ToString());
        void IFullLogger.Debug<T>(IFormatProvider formatProvider, T value) => _Logger.Debug(string.Format(formatProvider, "{0}", value));
        void IFullLogger.Debug(IFormatProvider formatProvider, string message, params object[] args) => _Logger.Debug(string.Format(formatProvider, message, args));
        void IFullLogger.Debug(string message) => _Logger.Debug(message);
        void IFullLogger.Debug<T>(string message) => _Logger.ForContext<T>().Debug(message);
        void IFullLogger.Debug(string message, params object[] args) => _Logger.Debug(message, args);
        void IFullLogger.Debug<T>(string message, params object[] args) => _Logger.ForContext<T>().Debug(message, args);
        void IFullLogger.Debug<TArgument>(IFormatProvider formatProvider, string message, TArgument argument) => _Logger.Debug(string.Format(formatProvider, message, argument));
        void IFullLogger.Debug<TArgument>(string message, TArgument argument) => _Logger.Debug(message, argument);
        void IFullLogger.Debug<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1, TArgument2 argument2) => _Logger.Debug(string.Format(formatProvider, message, argument1, argument2));
        void IFullLogger.Debug<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2) => _Logger.Debug(message, argument1, argument2);
        void IFullLogger.Debug<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3) => _Logger.Debug(string.Format(formatProvider, message, argument1, argument2, argument3));
        void IFullLogger.Debug<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3) => _Logger.Debug(message, argument1, argument2, argument3);
        void IFullLogger.DebugException(string message, Exception exception) => _Logger.Debug(exception, message);

        void IFullLogger.Error<T>(T value) => _Logger.Error(value?.ToString());
        void IFullLogger.Error<T>(IFormatProvider formatProvider, T value) => _Logger.Error(string.Format(formatProvider, "{0}", value));
        void IFullLogger.Error(IFormatProvider formatProvider, string message, params object[] args) => _Logger.Error(string.Format(formatProvider, message, args));
        void IFullLogger.Error(string message) => _Logger.Error(message);
        void IFullLogger.Error<T>(string message) => _Logger.ForContext<T>().Error(message);
        void IFullLogger.Error(string message, params object[] args) => _Logger.Error(message, args);
        void IFullLogger.Error<T>(string message, params object[] args) => _Logger.ForContext<T>().Error(message, args);
        void IFullLogger.Error<TArgument>(IFormatProvider formatProvider, string message, TArgument argument) => _Logger.Error(string.Format(formatProvider, message, argument));
        void IFullLogger.Error<TArgument>(string message, TArgument argument) => _Logger.Error(message, argument);
        void IFullLogger.Error<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1, TArgument2 argument2) => _Logger.Error(string.Format(formatProvider, message, argument1, argument2));
        void IFullLogger.Error<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2) => _Logger.Error(message, argument1, argument2);
        void IFullLogger.Error<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3) => _Logger.Error(string.Format(formatProvider, message, argument1, argument2, argument3));
        void IFullLogger.Error<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3) => _Logger.Error(message, argument1, argument2, argument3);
        void IFullLogger.ErrorException(string message, Exception exception) => _Logger.Error(exception, message);

        void IFullLogger.Fatal<T>(T value) => _Logger.Fatal(value?.ToString());
        void IFullLogger.Fatal<T>(IFormatProvider formatProvider, T value) => _Logger.Fatal(string.Format(formatProvider, "{0}", value));
        void IFullLogger.Fatal(IFormatProvider formatProvider, string message, params object[] args) => _Logger.Fatal(string.Format(formatProvider, message, args));
        void IFullLogger.Fatal(string message) => _Logger.Fatal(message);
        void IFullLogger.Fatal<T>(string message) => _Logger.ForContext<T>().Fatal(message);
        void IFullLogger.Fatal(string message, params object[] args) => _Logger.Fatal(message, args);
        void IFullLogger.Fatal<T>(string message, params object[] args) => _Logger.ForContext<T>().Fatal(message, args);
        void IFullLogger.Fatal<TArgument>(IFormatProvider formatProvider, string message, TArgument argument) => _Logger.Fatal(string.Format(formatProvider, message, argument));
        void IFullLogger.Fatal<TArgument>(string message, TArgument argument) => _Logger.Fatal(message, argument);
        void IFullLogger.Fatal<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1, TArgument2 argument2) => _Logger.Fatal(string.Format(formatProvider, message, argument1, argument2));
        void IFullLogger.Fatal<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2) => _Logger.Fatal(message, argument1, argument2);
        void IFullLogger.Fatal<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3) => _Logger.Fatal(string.Format(formatProvider, message, argument1, argument2, argument3));
        void IFullLogger.Fatal<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3) => _Logger.Fatal(message, argument1, argument2, argument3);
        void IFullLogger.FatalException(string message, Exception exception) => _Logger.Fatal(exception, message);

        void IFullLogger.Info<T>(T value) => _Logger.Information(value?.ToString());
        void IFullLogger.Info<T>(IFormatProvider formatProvider, T value) => _Logger.Information(string.Format(formatProvider, "{0}", value));
        void IFullLogger.Info(IFormatProvider formatProvider, string message, params object[] args) => _Logger.Information(string.Format(formatProvider, message, args));
        void IFullLogger.Info(string message) => _Logger.Information(message);
        void IFullLogger.Info<T>(string message) => _Logger.ForContext<T>().Information(message);
        void IFullLogger.Info(string message, params object[] args) => _Logger.Information(message, args);
        void IFullLogger.Info<T>(string message, params object[] args) => _Logger.ForContext<T>().Information(message, args);
        void IFullLogger.Info<TArgument>(IFormatProvider formatProvider, string message, TArgument argument) => _Logger.Information(string.Format(formatProvider, message, argument));
        void IFullLogger.Info<TArgument>(string message, TArgument argument) => _Logger.Information(message, argument);
        void IFullLogger.Info<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1, TArgument2 argument2) => _Logger.Information(string.Format(formatProvider, message, argument1, argument2));
        void IFullLogger.Info<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2) => _Logger.Information(message, argument1, argument2);
        void IFullLogger.Info<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3) => _Logger.Information(string.Format(formatProvider, message, argument1, argument2, argument3));
        void IFullLogger.Info<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3) => _Logger.Information(message, argument1, argument2, argument3);
        void IFullLogger.InfoException(string message, Exception exception) => _Logger.Information(exception, message);

        void IFullLogger.Warn<T>(T value) => _Logger.Warning(value?.ToString());
        void IFullLogger.Warn<T>(IFormatProvider formatProvider, T value) => _Logger.Warning(string.Format(formatProvider, "{0}", value));
        void IFullLogger.Warn(IFormatProvider formatProvider, string message, params object[] args) => _Logger.Warning(string.Format(formatProvider, message, args));
        void IFullLogger.Warn(string message) => _Logger.Warning(message);
        void IFullLogger.Warn<T>(string message) => _Logger.ForContext<T>().Warning(message);
        void IFullLogger.Warn(string message, params object[] args) => _Logger.Warning(message, args);
        void IFullLogger.Warn<T>(string message, params object[] args) => _Logger.ForContext<T>().Warning(message, args);
        void IFullLogger.Warn<TArgument>(IFormatProvider formatProvider, string message, TArgument argument) => _Logger.Warning(string.Format(formatProvider, message, argument));
        void IFullLogger.Warn<TArgument>(string message, TArgument argument) => _Logger.Warning(message, argument);
        void IFullLogger.Warn<TArgument1, TArgument2>(IFormatProvider formatProvider, string message, TArgument1 argument1, TArgument2 argument2) => _Logger.Warning(string.Format(formatProvider, message, argument1, argument2));
        void IFullLogger.Warn<TArgument1, TArgument2>(string message, TArgument1 argument1, TArgument2 argument2) => _Logger.Warning(message, argument1, argument2);
        void IFullLogger.Warn<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3) => _Logger.Warning(string.Format(formatProvider, message, argument1, argument2, argument3));
        void IFullLogger.Warn<TArgument1, TArgument2, TArgument3>(string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3) => _Logger.Warning(message, argument1, argument2, argument3);
        void IFullLogger.WarnException(string message, Exception exception) => _Logger.Warning(exception, message);

        void Splat.ILogger.Write(string message, Type type, LogLevel logLevel)
        {
            switch (logLevel)
            {
                case Splat.LogLevel.Debug:
                    _Logger.ForContext(type).Debug(message);
                    break;
                case Splat.LogLevel.Error:
                    _Logger.ForContext(type).Error(message);
                    break;
                case Splat.LogLevel.Fatal:
                    _Logger.ForContext(type).Fatal(message);
                    break;
                case Splat.LogLevel.Info:
                    _Logger.ForContext(type).Information(message);
                    break;
                case Splat.LogLevel.Warn:
                    _Logger.ForContext(type).Warning(message);
                    break;
                default:
                    _Logger.ForContext(type).Information(message);
                    break;
            }
        }

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
#pragma warning restore Serilog004 // Constant MessageTemplate verifier
