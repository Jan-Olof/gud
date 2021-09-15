using LaYumba.Functional;
using System;
using System.Text.Json;

namespace Generic.Common.Helpers
{
    public static class JsonHelper
    {
        public static JsonSerializerOptions CaseInsensitive() =>
            new()
            {
                PropertyNameCaseInsensitive = true,
            };

        public static Exceptional<T> Deserialize<T>(this string obj) where T : class
        {
            try
            {
                return JsonSerializer.Deserialize<T>(obj, CaseInsensitive())
                    ?? (Exceptional<T>)new ArgumentNullException("Object to deserialize is null.");
            }
            catch (Exception e)
            {
                return e;
            }
        }
    }
}