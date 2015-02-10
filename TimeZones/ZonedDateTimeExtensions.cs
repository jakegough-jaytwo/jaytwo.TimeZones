using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jaytwo.TimeZoneLib
{
    internal static class ZonedDateTimeExtensions
	{
		public static ZonedDateTime InUtc(this ZonedDateTime time)
		{
			return time.ToInstant().InUtc();
		}

		public static ZonedDateTime InZone(this ZonedDateTime time, string targetZoneName)
		{
			return TimeUtility.ConvertBetweenZoneLocalTimes(time, targetZoneName);
		}

		public static double ToUnixTime(this ZonedDateTime time)
		{
			return TimeUtility.GetUnixTimeFromZonedDateTime(time);
		}

		public static string ToUtcTimeISO8601String(this ZonedDateTime time)
		{
			return TimeUtility.GetUtcTimeISO8601String(time);
		}

		public static string ToZoneLocalTimeSortableTimeString(this ZonedDateTime time)
		{
			return TimeUtility.GetZoneLocalTimeSortableTimeString(time);
		}

		public static ZonedDateTime TruncateToSecondPrecision(this ZonedDateTime value)
		{
			return TimeUtility.TruncateToSecondPrecision(value);
		}

		public static ZonedDateTime TruncateToMinutePrecision(this ZonedDateTime value)
		{
			return TimeUtility.TruncateToMinutePrecision(value);
		}

		public static ZonedDateTime WithZone(this ZonedDateTime time, string targetZoneName)
		{
			return TimeUtility.ConvertBetweenZoneLocalTimes(time, targetZoneName);
		}
    }
}
