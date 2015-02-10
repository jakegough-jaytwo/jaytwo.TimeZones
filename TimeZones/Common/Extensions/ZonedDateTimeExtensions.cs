using jaytwo.TimeZones;
using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jaytwo.Common.Extensions
{
	public static partial class ZonedDateTimeExtensions
	{
		public static ZonedDateTime InUtc(this ZonedDateTime value)
		{
			return value.ToInstant().InUtc();
		}

        public static ZonedDateTime? InUtc(this ZonedDateTime? value)
        {
            if (value.HasValue)
            {
                return InUtc(value.Value);
            }
            else
            {
                return null;
            }
        }

		public static ZonedDateTime InZone(this ZonedDateTime value, string targetTimeZone)
		{
			return TimeZoneUtility.ConvertTimeZone(value, targetTimeZone);
		}

        public static ZonedDateTime? InZone(this ZonedDateTime? value, string targetTimeZone)
        {
            return TimeZoneUtility.ConvertTimeZone(value, targetTimeZone);
        }

        public static DateTime? ToDateTimeUnspecified(this ZonedDateTime? value)
        {
            if (value.HasValue)
            {
                return value.Value.ToDateTimeUnspecified();
            }
            else
            {
                return null;
            }
        }

        public static DateTime? ToDateTimeUtc(this ZonedDateTime? value)
        {
            if (value.HasValue)
            {
                return value.Value.ToDateTimeUtc();
            }
            else
            {
                return null;
            }
        }

        public static Instant? ToInstant(this ZonedDateTime? value)
        {
            if (value.HasValue)
            {
                return value.Value.ToInstant();
            }
            else
            {
                return null;
            }
        }

		public static string ToUtcTimeIso8601String(this ZonedDateTime value)
		{
			return TimeZoneUtility.GetUtcTimeIso8601String(value);
		}

        public static string ToUtcTimeIso8601String(this ZonedDateTime? value)
        {
            return TimeZoneUtility.GetUtcTimeIso8601String(value);
        }

		public static ZonedDateTime TruncateToSecondPrecision(this ZonedDateTime value)
		{
			return NodaTimeHelpers.TruncateToSecondPrecision(value);
		}

        public static ZonedDateTime? TruncateToSecondPrecision(this ZonedDateTime? value)
        {
			return NodaTimeHelpers.TruncateToSecondPrecision(value);
        }

		public static ZonedDateTime TruncateToMinutePrecision(this ZonedDateTime value)
		{
			return NodaTimeHelpers.TruncateToMinutePrecision(value);
		}

        public static ZonedDateTime? TruncateToMinutePrecision(this ZonedDateTime? value)
        {
			return NodaTimeHelpers.TruncateToMinutePrecision(value);
        }
    }
}
