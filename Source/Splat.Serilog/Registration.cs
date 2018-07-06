namespace Splat.Serilog
{
    /// <summary>
    /// Used to register Serilog with as the Splat logger
    /// </summary>
    public static class Registration
    {
        /// <summary>
        /// Registers Serilog as the Splat logger.
        /// </summary>
        /// <param name="logger">The Serilog logger.</param>
        public static void Register(global::Serilog.ILogger logger)
        {
            Splat.Locator.CurrentMutable.RegisterConstant(new SerilogLogger(logger), typeof(Splat.ILogger));
        }
    }
}
