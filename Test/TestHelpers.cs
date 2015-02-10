using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jaytwo.Common.Extensions;

namespace jaytwo.TimeZones.Test
{
    internal static class TestHelpers
    {
        public static string GetTimeString(Instant? value)
        {
            if (value.HasValue)
            {
                return GetTimeString(value.Value.ToDateTimeUtc());
            }
            else
            {
                return null;
            }
        }

        public static string GetTimeString(ZonedDateTime? value)
        {
            return GetTimeString(value.ToDateTimeUnspecified());
        }

        public static string GetTimeString(DateTime? value)
        {
            if (value.HasValue)
            {
                if (value.Value.Millisecond > 0)
                {
                    return value.Value.ToString("yyyy-MM-ddTHH:mm:ss.ff");
                }
                else
                {
                    return value.Value.ToString("yyyy-MM-ddTHH:mm:ss");
                }
            }
            else
            {
                return null;
            }
        }
    }
}
