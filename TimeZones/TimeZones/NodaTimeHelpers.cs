using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jaytwo.TimeZones
{
	public static class NodaTimeHelpers
	{
		#region GetTotalDays
		public static double GetTotalDays(Duration duration)
		{
			return duration.ToTimeSpan().TotalDays;
		}

		public static double? GetTotalDays(Duration? duration)
		{
			if (duration.HasValue)
			{
				return GetTotalDays(duration.Value);
			}
			else
			{
				return null;
			}
		}
		#endregion

		#region GetTotalHours
		public static double GetTotalHours(Duration duration)
		{
			return duration.ToTimeSpan().TotalHours;
		}

		public static double? GetTotalHours(Duration? duration)
		{
			if (duration.HasValue)
			{
				return GetTotalHours(duration.Value);
			}
			else
			{
				return null;
			}
		}
		#endregion

		#region GetTotalMinutes
		public static double GetTotalMinutes(Duration duration)
		{
			return duration.ToTimeSpan().TotalMinutes;
		}

		public static double? GetTotalMinutes(Duration? duration)
		{
			if (duration.HasValue)
			{
				return GetTotalMinutes(duration.Value);
			}
			else
			{
				return null;
			}
		}
		#endregion

		#region GetTotalSeconds
		public static double GetTotalSeconds(Duration duration)
		{
			return duration.ToTimeSpan().TotalSeconds;
		}

		public static double? GetTotalSeconds(Duration? duration)
		{
			if (duration.HasValue)
			{
				return GetTotalSeconds(duration.Value);
			}
			else
			{
				return null;
			}
		}
		#endregion

		#region GetTotalMilliseconds
		public static double GetTotalMilliseconds(Duration duration)
		{
			return duration.ToTimeSpan().TotalMilliseconds;
		}

		public static double? GetTotalMilliseconds(Duration? duration)
		{
			if (duration.HasValue)
			{
				return GetTotalMilliseconds(duration.Value);
			}
			else
			{
				return null;
			}
		}
		#endregion

		#region TruncateToSecondPrecision
		public static ZonedDateTime TruncateToSecondPrecision(ZonedDateTime value)
		{
			var ticksTruncated = (long)(Math.Floor((double)value.ToInstant().Ticks / (double)TimeSpan.TicksPerSecond) * TimeSpan.TicksPerSecond);
			return new ZonedDateTime(new Instant(ticksTruncated), value.Zone);
		}

		public static ZonedDateTime? TruncateToSecondPrecision(ZonedDateTime? value)
		{
			if (value.HasValue)
			{
				return TruncateToSecondPrecision(value.Value);
			}
			else
			{
				return null;
			}
		}
		#endregion

		#region TruncateToMinutePrecision
		public static ZonedDateTime TruncateToMinutePrecision(ZonedDateTime value)
		{
			var ticksTruncated = (long)(Math.Floor((double)value.ToInstant().Ticks / (double)TimeSpan.TicksPerMinute) * TimeSpan.TicksPerMinute);
			return new ZonedDateTime(new Instant(ticksTruncated), value.Zone);
		}

		public static ZonedDateTime? TruncateToMinutePrecision(ZonedDateTime? value)
		{
			if (value.HasValue)
			{
				return TruncateToMinutePrecision(value.Value);
			}
			else
			{
				return null;
			}
		}
		#endregion
	}
}
