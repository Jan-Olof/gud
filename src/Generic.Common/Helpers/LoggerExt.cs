using Microsoft.Extensions.Logging;
using System;
using static LaYumba.Functional.F;
using Unit = System.ValueTuple;

namespace Generic.Common.Helpers
{
    public static class LoggerExt
    {
        public static Unit Log(this Exception e, ILogger l)
        {
            l.LogError(e, e.Message);
            return Unit();
        }
    }
}