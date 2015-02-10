using jaytwo.Common.Time;
using NodaTime;
using NodaTime.TimeZones;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using jaytwo.Common.Extensions;

namespace jaytwo.TimeZones
{
    public static class TimeZoneUtility
    {
        public static IList<string> GetOlsonTimeZones()
        {
            return DateTimeZoneProviders.Tzdb.Ids;
        }

		#region ConvertTimeZone
		/// <summary>
		/// Creates a new <see cref="T:System.DateTime" /> representing source date/time in the <code>targetTimeZone</code>.
		/// </summary>
		/// <param name="sourceLocalTime">Source Local Time.  <see cref="P:System.DateTime.Kind" /> is ignored.</param>
		/// <param name="sourceTimeZone">Tzdb/Olson Time Zone, CLDR TimeZone Key, or canonical <see cref="T:jaytwo.TimeZones.TimeZoneListItem" /> Id</param>
		/// <param name="targetTimeZone">Tzdb/Olson Time Zone, CLDR TimeZone Key, or canonical <see cref="T:jaytwo.TimeZones.TimeZoneListItem" /> Id </param>
		/// <returns>The resulting date/time.</returns>
		public static DateTime ConvertTimeZone(DateTime sourceLocalTime, string sourceTimeZone, string targetTimeZone)
        {
            var utcTime = LocalTimeToUtc(sourceLocalTime, sourceTimeZone);
            return UtcToLocalTime(utcTime, targetTimeZone);
        }

		/// <summary>
		/// Creates a new <see cref="T:System.DateTime" /> representing source date/time in the <code>targetTimeZone</code>.
		/// Returns null if <code>sourceLocalTime</code> is null.
		/// </summary>
		/// <param name="sourceLocalTime">Source Local Time. <see cref="P:System.DateTime.Kind" /> is ignored.</param>
		/// <param name="sourceTimeZone">Tzdb/Olson Time Zone, CLDR TimeZone Key, or canonical <see cref="T:jaytwo.TimeZones.TimeZoneListItem" /> Id</param>
		/// <param name="targetTimeZone">Tzdb/Olson Time Zone, CLDR TimeZone Key, or canonical <see cref="T:jaytwo.TimeZones.TimeZoneListItem" /> Id </param>
		/// <returns>The resulting date/time.</returns>
        public static DateTime? ConvertTimeZone(DateTime? sourceLocalTime, string sourceTimeZone, string targetTimeZone)
        {
            if (sourceLocalTime.HasValue)
            {
                return ConvertTimeZone(sourceLocalTime.Value, sourceTimeZone, targetTimeZone);
            }
            else
            {
                return null;
            }
        }

		/// <summary>
		/// Creates a new <see cref="T:NodaTime.ZonedDateTime" /> representing source date/time in the <code>targetTimeZone</code>.
		/// </summary>
		/// <param name="source">Source Local Time.</param>
		/// <param name="targetTimeZone">Tzdb/Olson Time Zone, CLDR TimeZone Key, or canonical <see cref="T:jaytwo.TimeZones.TimeZoneListItem" /> Id</param>
		/// <returns>The resulting date/time.</returns>
        public static ZonedDateTime ConvertTimeZone(ZonedDateTime source, string targetTimeZone)
        {
            var utcTime = source.ToDateTimeUtc();
            return UtcToZonedDateTime(utcTime, targetTimeZone);
        }

		/// <summary>
		/// Creates a new <see cref="T:NodaTime.ZonedDateTime" /> representing source date/time in the <code>targetTimeZone</code>.
		/// Returns null if <code>sourceLocalTime</code> is null.
		/// </summary>
		/// <param name="source">Source Local Time.</param>
		/// <param name="targetTimeZone">Tzdb/Olson Time Zone, CLDR TimeZone Key, or canonical <see cref="T:jaytwo.TimeZones.TimeZoneListItem" /> Id</param>
		/// <returns>The resulting date/time.</returns>
        public static ZonedDateTime? ConvertTimeZone(ZonedDateTime? source, string targetTimeZone)
        {
            if (source.HasValue)
            {
                return ConvertTimeZone(source.Value, targetTimeZone);
            }
            else
            {
                return null;
            }
        }
		#endregion

		#region IsDaylightSavingTime
		public static bool IsDaylightSavingTimeAtLocalTime(DateTime sourceLocalTime, string sourceTimeZone)
        {
            var zonedDateTime = LocalTimeToZonedDateTime(sourceLocalTime, sourceTimeZone);
            return zonedDateTime.IsDaylightSavingTime();
        }

		public static bool IsDaylightSavingTimeAtUtc(DateTime utc, string targetTimeZone)
		{
			var zonedDateTime = UtcToZonedDateTime(utc, targetTimeZone);
			return zonedDateTime.IsDaylightSavingTime();
		}
		#endregion

		#region GetTimeZoneUtcOffset
		public static TimeSpan GetTimeZoneUtcOffsetAtUtc(DateTime utc, string timeZone)
        {
            var zonedDateTime = UtcToZonedDateTime(utc, timeZone);
            return zonedDateTime.Offset.ToTimeSpan();
        }

        public static TimeSpan GetTimeZoneUtcOffsetAtLocalTime(DateTime sourceLocalTime, string sourceTimeZone)
        {
            var zonedDateTime = LocalTimeToZonedDateTime(sourceLocalTime, sourceTimeZone);
            return zonedDateTime.Offset.ToTimeSpan();
        }
		#endregion

		#region LocalTimeToUtc
		/// <summary>
		/// Creates a new <see cref="T:System.DateTime" /> representing source date/time in UTC.
		/// </summary>
		/// <param name="sourceLocalTime">Source Local Time.  <see cref="P:System.DateTime.Kind" /> is ignored.</param>
		/// <param name="sourceTimeZone">Tzdb/Olson Time Zone, CLDR TimeZone Key, or canonical <see cref="T:jaytwo.TimeZones.TimeZoneListItem" /> Id</param>
		/// <returns>The resulting date/time.</returns>
		public static DateTime LocalTimeToUtc(DateTime sourceLocalTime, string sourceTimeZone)
        {
			var tzdbDateTimeZone = GetTzdbDateTimeZone(sourceTimeZone);
            var zonedDateTime = LocalDateTime.FromDateTime(sourceLocalTime).InZoneLeniently(tzdbDateTimeZone);
            return zonedDateTime.ToInstant().ToDateTimeUtc();
        }

		/// <summary>
		/// Creates a new <see cref="T:System.DateTime" /> representing source date/time in UTC.
		/// Returns null if <code>sourceLocalTime</code> is null.
		/// </summary>
		/// <param name="sourceLocalTime">Source Local Time.  <see cref="P:System.DateTime.Kind" /> is ignored.</param>
		/// <param name="sourceTimeZone">Tzdb/Olson Time Zone, CLDR TimeZone Key, or canonical <see cref="T:jaytwo.TimeZones.TimeZoneListItem" /> Id</param>
		/// <returns>The resulting date/time.</returns>
        public static DateTime? LocalTimeToUtc(DateTime? sourceLocalTime, string sourceTimeZone)
        {
            if (sourceLocalTime.HasValue)
            {
                return LocalTimeToUtc(sourceLocalTime.Value, sourceTimeZone);
            }
            else
            {
                return null;
            }
        }
		#endregion

		#region UtcToZonedDateTime
		private static ZonedDateTime UtcToZonedDateTime(DateTime utc, DateTimeZone tzdbDateTimeZone)
        {
            var utcTimeAsUtcKind = DateTime.SpecifyKind(utc, DateTimeKind.Utc);
            var instant = Instant.FromDateTimeUtc(utcTimeAsUtcKind);
            return instant.InZone(tzdbDateTimeZone);
        }

        public static ZonedDateTime UtcToZonedDateTime(DateTime utc, string targetTimeZone)
        {
			var tzdbDateTimeZone = GetTzdbDateTimeZone(targetTimeZone);
            return UtcToZonedDateTime(utc, tzdbDateTimeZone);
        }

        public static ZonedDateTime? UtcToZonedDateTime(DateTime? utc, string targetTimeZone)
        {
            if (utc.HasValue)
            {
                return UtcToZonedDateTime(utc.Value, targetTimeZone);
            }
            else
            {
                return null;
            }
        }

        public static ZonedDateTime UtcToZonedDateTime(DateTime utc)
        {
            var utcTimeAsUtcKind = DateTime.SpecifyKind(utc, DateTimeKind.Utc);
            var instant = Instant.FromDateTimeUtc(utcTimeAsUtcKind);
            return instant.InUtc();
        }

        public static ZonedDateTime? UtcToZonedDateTime(DateTime? utc)
        {
            if (utc.HasValue)
            {
                return UtcToZonedDateTime(utc.Value);
            }
            else
            {
                return null;
            }
        }
		#endregion

		#region LocalTimeToZonedDateTime
		private static ZonedDateTime LocalTimeToZonedDateTime(DateTime sourceLocalTime, DateTimeZone tzdbDateTimeZone)
        {
            var localDateTime = LocalDateTime.FromDateTime(sourceLocalTime);
            return tzdbDateTimeZone.AtLeniently(localDateTime);
        }

        public static ZonedDateTime LocalTimeToZonedDateTime(DateTime sourceLocalTime, string sourceTimeZone)
        {
            var tzdbDateTimeZone = GetTzdbDateTimeZone(sourceTimeZone);
            return LocalTimeToZonedDateTime(sourceLocalTime, tzdbDateTimeZone);
        }

        public static ZonedDateTime? LocalTimeToZonedDateTime(DateTime? sourceLocalTime, string sourceTimeZone)
        {
            if (sourceLocalTime.HasValue)
            {
                return LocalTimeToZonedDateTime(sourceLocalTime.Value, sourceTimeZone);
            }
            else
            {
                return null;
            }
        }
		#endregion

		#region UtcToLocalTime
		public static DateTime UtcToLocalTime(DateTime utc, string targetTimeZone)
        {
            var zonedDateTime = UtcToZonedDateTime(utc, targetTimeZone);
            return zonedDateTime.ToDateTimeUnspecified();
        }

        public static DateTime? UtcToLocalTime(DateTime? utc, string targetTimeZone)
        {
            if (utc.HasValue)
            {
                return UtcToLocalTime(utc.Value, targetTimeZone);
            }
            else
            {
                return null;
            }
        }
		#endregion

		#region GetUtcTimeIso8601String
		public static string GetUtcTimeIso8601String(ZonedDateTime time)
        {
            return TimeUtility.GetIso8601TimeString(time.ToDateTimeUtc());
        }

        public static string GetUtcTimeIso8601String(ZonedDateTime? time)
        {
            if (time.HasValue)
            {
                return GetUtcTimeIso8601String(time.Value);
            }
            else
            {
                return null;
            }
        }
		#endregion

		public static bool TimeZoneObservesDaylightSavingTime(string timeZone)
        {
            var now = UtcToZonedDateTime(TimeProvider.UtcNow);
            var plusOneYear = now.Plus(Duration.FromStandardDays(365));

            var tzdbDateTimeZone = GetTzdbDateTimeZone(timeZone);
            var result = tzdbDateTimeZone
                .GetZoneIntervals(now.ToInstant(), plusOneYear.ToInstant())
                .Any(x => x.Savings != Offset.Zero);

            return result;
        }

        public static DateTime? GetNextDaylightSavingBoundary(DateTime localTime, string timeZone)
        {
            var zone = GetTzdbDateTimeZone(timeZone);
            var zoned = LocalTimeToZonedDateTime(localTime, zone);
            var switchInstant = GetNextDaylightSavingBoundary(zoned);

            if (switchInstant != null)
            {
                return switchInstant.Value.InZone(zone).ToDateTimeUnspecified();
            }
            else
            {
                return null;
            }
        }

        public static Instant? GetNextDaylightSavingBoundary(ZonedDateTime value)
        {
            var plusOneYear = value.Plus(Duration.FromStandardDays(365));
            var intervals = value.Zone
                .GetZoneIntervals(value.ToInstant(), plusOneYear.ToInstant())
                .OrderBy(x => x.Start);

            var firstInterval = intervals.First();
            var switchInterval = intervals.FirstOrDefault(x => x.Savings != firstInterval.Savings);

            if (switchInterval != null)
            {
                return switchInterval.Start;
            }
            else
            {
                return null;
            }
        }

        private static DateTimeZone GetTzdbDateTimeZone(string timeZone)
        {
			if (string.IsNullOrEmpty(timeZone))
			{
				throw new ArgumentNullException("timeZone");
			}

            var tzdbId = TimeZoneRepositoryInternal.GetTzdbId(timeZone);
            return DateTimeZoneProviders.Tzdb[tzdbId];
        }
    }
}