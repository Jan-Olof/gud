using LaYumba.Functional;
using System;

namespace Generic.Common.Helpers
{
    public static class ExceptionalExt
    {
        public static T GetValue<T>(this Exceptional<T> ex) =>
            ex.Match(e => throw new Exception("Exceptional is an exception.", e), t => t);
    }
}