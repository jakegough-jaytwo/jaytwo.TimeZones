using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jaytwo.TimeZoneLib
{
	public static class DateTimeExtensions
	{
		public static double UtcTimeToUnixTime(this DateTime utcTime)
		{
			return TimeUtility.GetUnixTimeFromUtcTime(utcTime);
		}

		public static ZonedDateTime UtcTimeToZonedDateTime(this DateTime utcTime)
		{
			return TimeUtility.GetZonedDateTimeFromUtcTime(utcTime);
		}

		public static ZonedDateTime UtcTimeToZonedDateTime(this DateTime utcTime, string olsonTimeZoneName)
		{
			return TimeUtility.GetZonedDateTimeFromUtcTime(utcTime, olsonTimeZoneName);
		}

		public static DateTime UtcTimeToZoneLocalTime(this DateTime utcTime, string olsonTimeZoneName)
		{
			return TimeUtility.GetZoneLocalTimeFromUtcTime(utcTime, olsonTimeZoneName);
		}

		public static double ZoneLocalTimeToUnixTime(this DateTime zoneLocalTime, string olsonTimeZoneName)
		{
			return TimeUtility.GetUnixTimeFromZoneLocalTime(zoneLocalTime, olsonTimeZoneName);
		}

		public static DateTime ZoneLocalTimeToUtcTime(this DateTime zoneLocalTime, string olsonTimeZoneName)
		{
			return TimeUtility.GetUtcTimeFromZoneLocalTime(zoneLocalTime, olsonTimeZoneName);
		}

		public static ZonedDateTime ZoneLocalTimeToZonedDateTime(this DateTime zoneLocalTime, string olsonTimeZoneName)
		{
			return TimeUtility.GetZonedDateTimeFromZoneLocalTime(zoneLocalTime, olsonTimeZoneName);
		}
	}
}
