using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jaytwo.TimeZoneLib
{
	internal static class DurationExtensions
	{
		public static double GetTotalDays(this Duration duration)
		{
			return TimeUtility.GetTotalDays(duration);
		}

		public static double GetTotalHours(this Duration duration)
		{
			return TimeUtility.GetTotalHours(duration);
		}

		public static double GetTotalMinutes(this Duration duration)
		{
			return TimeUtility.GetTotalMinutes(duration);
		}

		public static double GetTotalSeconds(this Duration duration)
		{
			return TimeUtility.GetTotalSeconds(duration);
		}

		public static double GetTotalMilliseconds(this Duration duration)
		{
			return TimeUtility.GetTotalMilliseconds(duration);
		}
	}
}
