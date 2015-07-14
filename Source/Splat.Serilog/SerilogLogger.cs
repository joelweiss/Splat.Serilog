using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splat.Serilog
{
    public class SerilogLogger : Splat.ILogger
    {
        private readonly global::Serilog.ILogger _Logger;

        public SerilogLogger(global::Serilog.ILogger logger)
        {
            _Logger = logger;
        }

        public Splat.LogLevel Level { get; set; }

        public void Write(string message, Splat.LogLevel logLevel)
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
