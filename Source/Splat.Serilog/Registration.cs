using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splat.Serilog
{
    public static class Registration
    {
        public static void Register(global::Serilog.ILogger logger)
        {
            Splat.Locator.CurrentMutable.RegisterConstant(new SerilogLogger(logger), typeof(Splat.ILogger));
        }
    }
}
