using jaytwo.Common.Time;
using jaytwo.TimeZones;
using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jaytwo.Common.Extensions
{
	public static class DateTimeExtensions
	{
		/// <summary>
		/// Creates a new <see cref="T:System.DateTime" /> representing source date/time in the <code>targetTimeZone</code>.
		/// </summary>
		/// <param name="value">Source Local Time.  <see cref="P:System.DateTime.Kind" /> is ignored.</param>
		/// <param name="sourceTimeZone">Tzdb/Olson Time Zone, CLDR TimeZone Key, or canonical <see cref="T:jaytwo.TimeZones.TimeZoneListItem" /> Id</param>
		/// <param name="targetTimeZone">Tzdb/Olson Time Zone, CLDR TimeZone Key, or canonical <see cref="T:jaytwo.TimeZones.TimeZoneListItem" /> Id </param>
		/// <returns>The resulting date/time.</returns>
		public static DateTime ConvertTimeZone(this DateTime value, string sourceTimeZone, string targetTimeZone)
		{
			return TimeZoneUtility.ConvertTimeZone(value, sourceTimeZone, targetTimeZone);
		}

		/// <summary>
		/// Creates a new <see cref="T:System.DateTime" /> representing source date/time in the <code>targetTimeZone</code>.
		/// Returns null if <code>value</code> is null.
		/// </summary>
		/// <param name="value">Source Local Time.  <see cref="P:System.DateTime.Kind" /> is ignored.</param>
		/// <param name="sourceTimeZone">Tzdb/Olson Time Zone, CLDR TimeZone Key, or canonical <see cref="T:jaytwo.TimeZones.TimeZoneListItem" /> Id</param>
		/// <param name="targetTimeZone">Tzdb/Olson Time Zone, CLDR TimeZone Key, or canonical <see cref="T:jaytwo.TimeZones.TimeZoneListItem" /> Id </param>
		/// <returns>The resulting date/time.</returns>
		public static DateTime? ConvertTimeZone(this DateTime? value, string sourceTimeZone, string targetTimeZone)
		{
			return TimeZoneUtility.ConvertTimeZone(value, sourceTimeZone, targetTimeZone);
		}

		/// <summary>
		/// Creates a new <see cref="T:System.DateTime" /> representing source date/time in UTC.
		/// </summary>
		/// <param name="value">Source Local Time.  <see cref="P:System.DateTime.Kind" /> is ignored.</param>
		/// <param name="sourceTimeZone">Tzdb/Olson Time Zone, CLDR TimeZone Key, or canonical <see cref="T:jaytwo.TimeZones.TimeZoneListItem" /> Id</param>
		/// <returns>The resulting date/time.</returns>
		public static DateTime LocalTimeToUtc(this DateTime value, string sourceTimeZone)
		{
			return TimeZoneUtility.LocalTimeToUtc(value, sourceTimeZone);
		}

		/// <summary>
		/// Creates a new <see cref="T:System.DateTime" /> representing source date/time in UTC.
		/// Returns null if <code>sourceLocalTime</code> is null.
		/// </summary>
		/// <param name="value">Source Local Time.  <see cref="P:System.DateTime.Kind" /> is ignored.</param>
		/// <param name="sourceTimeZone">Tzdb/Olson Time Zone, CLDR TimeZone Key, or canonical <see cref="T:jaytwo.TimeZones.TimeZoneListItem" /> Id</param>
		/// <returns>The resulting date/time.</returns>
		public static DateTime? LocalTimeToUtc(this DateTime? value, string sourceTimeZone)
		{
			return TimeZoneUtility.LocalTimeToUtc(value, sourceTimeZone);
		}

		public static ZonedDateTime LocalTimeToZonedDateTime(this DateTime value, string sourceTimeZone)
		{
			return TimeZoneUtility.LocalTimeToZonedDateTime(value, sourceTimeZone);
		}

		public static ZonedDateTime? LocalTimeToZonedDateTime(this DateTime? value, string sourceTimeZone)
		{
			return TimeZoneUtility.LocalTimeToZonedDateTime(value, sourceTimeZone);
		}

		public static ZonedDateTime UtcToZonedDateTime(this DateTime value)
		{
			return TimeZoneUtility.UtcToZonedDateTime(value);
		}

		public static ZonedDateTime? UtcToZonedDateTime(this DateTime? value)
		{
			return TimeZoneUtility.UtcToZonedDateTime(value);
		}

		public static ZonedDateTime UtcToZonedDateTime(this DateTime value, string targetTimeZone)
		{
			return TimeZoneUtility.UtcToZonedDateTime(value, targetTimeZone);
		}

		public static ZonedDateTime? UtcToZonedDateTime(this DateTime? value, string targetTimeZone)
		{
			return TimeZoneUtility.UtcToZonedDateTime(value, targetTimeZone);
		}

		public static DateTime UtcToLocalTime(this DateTime value, string targetTimeZone)
		{
			return TimeZoneUtility.UtcToLocalTime(value, targetTimeZone);
		}

		public static DateTime? UtcToLocalTime(this DateTime? value, string targetTimeZone)
		{
			return TimeZoneUtility.UtcToLocalTime(value, targetTimeZone);
		}
	}
}
