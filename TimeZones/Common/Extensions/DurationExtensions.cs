using jaytwo.TimeZones;
using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jaytwo.Common.Extensions
{
	public static class DurationExtensions
	{
		public static double GetTotalDays(this Duration value)
		{
			return NodaTimeHelpers.GetTotalDays(value);
		}

        public static double? GetTotalDays(this Duration? value)
        {
			return NodaTimeHelpers.GetTotalDays(value);
        }

		public static double GetTotalHours(this Duration value)
		{
			return NodaTimeHelpers.GetTotalHours(value);
		}

        public static double? GetTotalHours(this Duration? value)
        {
			return NodaTimeHelpers.GetTotalHours(value);
        }

		public static double GetTotalMinutes(this Duration value)
		{
			return NodaTimeHelpers.GetTotalMinutes(value);
		}

        public static double? GetTotalMinutes(this Duration? value)
        {
			return NodaTimeHelpers.GetTotalMinutes(value);
        }

		public static double GetTotalSeconds(this Duration value)
		{
			return NodaTimeHelpers.GetTotalSeconds(value);
		}

		public static double? GetTotalSeconds(this Duration? value)
        {
			return NodaTimeHelpers.GetTotalSeconds(value);
        }

		public static double GetTotalMilliseconds(this Duration value)
		{
			return NodaTimeHelpers.GetTotalMilliseconds(value);
		}

		public static double? GetTotalMilliseconds(this Duration? value)
        {
			return NodaTimeHelpers.GetTotalMilliseconds(value);
        }
	}
}
