using NodaTime;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using jaytwo.Common.Extensions;

namespace jaytwo.TimeZones.Test.TimeZones
{
    [TestFixture]
    public static class DateTimeExtensionsTests
    {
        #region ConvertTimeZone
        private static IEnumerable<TestCaseData> TimeZoneUtility_ConvertTimeZone_TestCases()
        {
            yield return new TestCaseData("2014-01-01T09:00:00", null, "usnyc").Throws(typeof(ArgumentNullException));
            yield return new TestCaseData("2014-01-01T09:00:00", string.Empty, "usnyc").Throws(typeof(ArgumentNullException));
            yield return new TestCaseData("2014-01-01T09:00:00", "usden", null).Throws(typeof(ArgumentNullException));
            yield return new TestCaseData("2014-01-01T09:00:00", "usden", string.Empty).Throws(typeof(ArgumentNullException));
            yield return new TestCaseData("2014-01-01T09:00:00", "usden", "usnyc").Returns("2014-01-01T11:00:00");
            yield return new TestCaseData("2014-01-01T09:00:00", "America/Denver", "America/New_York").Returns("2014-01-01T11:00:00");
        }

        [Test]
        [TestCaseSource("TimeZoneUtility_ConvertTimeZone_TestCases")]
        public static string ZonedDateTimeExtensions_ConvertTimeZone(string sourceTime, string sourceZone, string targetZone)
        {
            var time = sourceTime.ParseDateTime();
            var result = time.ConvertTimeZone(sourceZone, targetZone);
            return TestHelpers.GetTimeString(result);
        }

        [Test]
        [TestCase(null, "America/Denver", "America/New_York", Result = null)]
        [TestCaseSource("TimeZoneUtility_ConvertTimeZone_TestCases")]
        public static string ZonedDateTimeExtensions_ConvertTimeZone_nullable(string sourceTime, string sourceZone, string targetZone)
        {
            var time = sourceTime.TryParseDateTime();
            var result = time.ConvertTimeZone(sourceZone, targetZone);
            return TestHelpers.GetTimeString(result);
        }

        [Test]
        [TestCaseSource("TimeZoneUtility_ConvertTimeZone_TestCases")]
        public static string TimeZoneUtility_ConvertTimeZone(string sourceTime, string sourceZone, string targetZone)
        {
            var time = sourceTime.ParseDateTime();
            var result = TimeZoneUtility.ConvertTimeZone(time, sourceZone, targetZone);
            return TestHelpers.GetTimeString(result);
        }

        [Test]
        [TestCase(null, "America/Denver", "America/New_York", Result = null)]
        [TestCaseSource("TimeZoneUtility_ConvertTimeZone_TestCases")]
        public static string TimeZoneUtility_ConvertTimeZone_nullable(string sourceTime, string sourceZone, string targetZone)
        {
            var time = sourceTime.TryParseDateTime();
            var result = TimeZoneUtility.ConvertTimeZone(time, sourceZone, targetZone);
            return TestHelpers.GetTimeString(result);
        }
        #endregion

        #region UtcToLocalTime
		private static IEnumerable<TestCaseData> ZonedDateTimeExtensions_UtcToLocalTime_TestCases()
        {
            yield return new TestCaseData("2014-01-01T09:00:00", null).Throws(typeof(ArgumentNullException));
            yield return new TestCaseData("2014-01-01T09:00:00", string.Empty).Throws(typeof(ArgumentNullException));
            yield return new TestCaseData("2014-01-01T09:00:00", "usden").Returns("2014-01-01T02:00:00");
            yield return new TestCaseData("2014-01-01T09:00:00", "America/Denver").Returns("2014-01-01T02:00:00");
        }

        [Test]
		[TestCaseSource("ZonedDateTimeExtensions_UtcToLocalTime_TestCases")]
        public static string ZonedDateTimeExtensions_UtcToLocalTime(string utc, string zone)
        {
            var time = utc.ParseDateTime();
            var result = time.UtcToLocalTime(zone);
            return TestHelpers.GetTimeString(result);
        }

        [Test]
        [TestCase(null, "America/Denver", Result = null)]
		[TestCaseSource("ZonedDateTimeExtensions_UtcToLocalTime_TestCases")]
        public static string ZonedDateTimeExtensions_UtcToLocalTime_nullable(string utc, string zone)
        {
            var time = utc.TryParseDateTime();
            var result = time.UtcToLocalTime(zone);
            return TestHelpers.GetTimeString(result);
        }

        [Test]
		[TestCaseSource("ZonedDateTimeExtensions_UtcToLocalTime_TestCases")]
		public static string TimeZoneUtility_UtcToLocalTime(string utc, string zone)
        {
            var time = utc.ParseDateTime();
            var result = TimeZoneUtility.UtcToLocalTime(time, zone);
            return TestHelpers.GetTimeString(result);
        }

        [Test]
        [TestCase(null, "America/Denver", Result = null)]
		[TestCaseSource("ZonedDateTimeExtensions_UtcToLocalTime_TestCases")]
		public static string TimeZoneUtility_UtcToLocalTime_nullable(string utc, string zone)
        {
            var time = utc.TryParseDateTime();
            var result = TimeZoneUtility.UtcToLocalTime(time, zone);
            return TestHelpers.GetTimeString(result);
        }
        #endregion

        #region UtcToZonedDateTime
		private static IEnumerable<TestCaseData> TimeZoneUtility_UtcToZonedDateTime_TestCases()
        {
            yield return new TestCaseData("2014-01-01T02:00:00").Returns("2014-01-01T02:00:00");
        }

        [Test]
		[TestCaseSource("TimeZoneUtility_UtcToZonedDateTime_TestCases")]
        public static string ZonedDateTimeExtensions_UtcToZonedDateTime(string utc)
        {
            var time = utc.ParseDateTime();
            var result = time.UtcToZonedDateTime();
            return TestHelpers.GetTimeString(result);
        }

        [Test]
        [TestCase(null, Result = null)]
		[TestCaseSource("TimeZoneUtility_UtcToZonedDateTime_TestCases")]
        public static string ZonedDateTimeExtensions_UtcToZonedDateTime_nullable(string utc)
        {
            var time = utc.TryParseDateTime();
            var result = time.UtcToZonedDateTime();
            return TestHelpers.GetTimeString(result);
        }

        [Test]
		[TestCaseSource("TimeZoneUtility_UtcToZonedDateTime_TestCases")]
		public static string TimeZoneUtility_UtcToZonedDateTime(string utc)
        {
            var time = utc.ParseDateTime();
            var result = TimeZoneUtility.UtcToZonedDateTime(time);
            return TestHelpers.GetTimeString(result);
        }

        [Test]
        [TestCase(null, Result = null)]
		[TestCaseSource("TimeZoneUtility_UtcToZonedDateTime_TestCases")]
		public static string TimeZoneUtility_UtcToZonedDateTime_nullable(string utc)
        {
            var time = utc.TryParseDateTime();
            var result = TimeZoneUtility.UtcToZonedDateTime(time);
            return TestHelpers.GetTimeString(result);
        }
        #endregion

        #region UtcToZonedDateTime_With_Zone
		private static IEnumerable<TestCaseData> TimeZoneUtility_UtcToZonedDateTime_With_Zone_TestCases()
        {
            yield return new TestCaseData("2014-01-01T09:00:00", null).Throws(typeof(ArgumentNullException));
            yield return new TestCaseData("2014-01-01T09:00:00", string.Empty).Throws(typeof(ArgumentNullException));
            yield return new TestCaseData("2014-01-01T09:00:00", "usden").Returns("2014-01-01T02:00:00");
            yield return new TestCaseData("2014-01-01T09:00:00", "America/Denver").Returns("2014-01-01T02:00:00");
        }

        [Test]
		[TestCaseSource("TimeZoneUtility_UtcToZonedDateTime_With_Zone_TestCases")]
        public static string ZonedDateTimeExtensions_UtcToZonedDateTime_With_Zone(string utc, string zone)
        {
            var time = utc.ParseDateTime();
            var result = time.UtcToZonedDateTime(zone);
            return TestHelpers.GetTimeString(result);
        }

        [Test]
        [TestCase(null, "America/Denver", Result = null)]
		[TestCaseSource("TimeZoneUtility_UtcToZonedDateTime_With_Zone_TestCases")]
        public static string ZonedDateTimeExtensions_UtcToZonedDateTime_With_Zone_nullable(string utc, string zone)
        {
            var time = utc.TryParseDateTime();
            var result = time.UtcToZonedDateTime(zone);
            return TestHelpers.GetTimeString(result);
        }

        [Test]
		[TestCaseSource("TimeZoneUtility_UtcToZonedDateTime_With_Zone_TestCases")]
		public static string TimeZoneUtility_UtcToZonedDateTime_With_Zone(string utc, string zone)
        {
            var time = utc.ParseDateTime();
            var result = TimeZoneUtility.UtcToZonedDateTime(time, zone);
            return TestHelpers.GetTimeString(result);
        }

        [Test]
        [TestCase(null, "America/Denver", Result = null)]
		[TestCaseSource("TimeZoneUtility_UtcToZonedDateTime_With_Zone_TestCases")]
		public static string TimeZoneUtility_UtcToZonedDateTime_With_Zone_nullable(string utc, string zone)
        {
            var time = utc.TryParseDateTime();
            var result = TimeZoneUtility.UtcToZonedDateTime(time, zone);
            return TestHelpers.GetTimeString(result);
        }
        #endregion

        #region LocalTimeToUtc
		private static IEnumerable<TestCaseData> TimeZoneUtility_LocalTimeToUtc_TestCases()
        {
            yield return new TestCaseData("2014-01-01T09:00:00", null).Throws(typeof(ArgumentNullException));
            yield return new TestCaseData("2014-01-01T09:00:00", string.Empty).Throws(typeof(ArgumentNullException));
            yield return new TestCaseData("2014-01-01T02:00:00", "usden").Returns("2014-01-01T09:00:00");
            yield return new TestCaseData("2014-01-01T02:00:00", "America/Denver").Returns("2014-01-01T09:00:00");
        }

        [Test]
		[TestCaseSource("TimeZoneUtility_LocalTimeToUtc_TestCases")]
        public static string ZonedDateTimeExtensions_LocalTimeToUtc(string utc, string zone)
        {
            var time = utc.ParseDateTime();
            var result = time.LocalTimeToUtc(zone);
            return TestHelpers.GetTimeString(result);
        }

        [Test]
        [TestCase(null, "America/Denver", Result = null)]
		[TestCaseSource("TimeZoneUtility_LocalTimeToUtc_TestCases")]
        public static string ZonedDateTimeExtensions_LocalTimeToUtc_nullable(string utc, string zone)
        {
            var time = utc.TryParseDateTime();
            var result = time.LocalTimeToUtc(zone);
            return TestHelpers.GetTimeString(result);
        }

        [Test]
		[TestCaseSource("TimeZoneUtility_LocalTimeToUtc_TestCases")]
		public static string TimeZoneUtility_LocalTimeToUtc(string utc, string zone)
        {
            var time = utc.ParseDateTime();
            var result = TimeZoneUtility.LocalTimeToUtc(time, zone);
            return TestHelpers.GetTimeString(result);
        }

        [Test]
        [TestCase(null, "America/Denver", Result = null)]
		[TestCaseSource("TimeZoneUtility_LocalTimeToUtc_TestCases")]
		public static string TimeZoneUtility_LocalTimeToUtc_nullable(string utc, string zone)
        {
            var time = utc.TryParseDateTime();
            var result = TimeZoneUtility.LocalTimeToUtc(time, zone);
            return TestHelpers.GetTimeString(result);
        }
        #endregion

        #region LocalTimeToZonedDateTime
		private static IEnumerable<TestCaseData> TimeZoneUtility_LocalTimeToZonedDateTime_TestCases()
        {
            yield return new TestCaseData("2014-01-01T09:00:00", null).Throws(typeof(ArgumentNullException));
            yield return new TestCaseData("2014-01-01T09:00:00", string.Empty).Throws(typeof(ArgumentNullException));
            yield return new TestCaseData("2014-01-01T09:00:00", "usden").Returns("2014-01-01T09:00:00");
            yield return new TestCaseData("2014-01-01T09:00:00", "America/Denver").Returns("2014-01-01T09:00:00");
        }

        [Test]
		[TestCaseSource("TimeZoneUtility_LocalTimeToZonedDateTime_TestCases")]
        public static string ZonedDateTimeExtensions_LocalTimeToZonedDateTime(string utc, string zone)
        {
            var time = utc.ParseDateTime();
            var result = time.LocalTimeToZonedDateTime(zone);
            return TestHelpers.GetTimeString(result);
        }

        [Test]
        [TestCase(null, "America/Denver", Result = null)]
		[TestCaseSource("TimeZoneUtility_LocalTimeToZonedDateTime_TestCases")]
        public static string ZonedDateTimeExtensions_LocalTimeToZonedDateTime_nullable(string utc, string zone)
        {
            var time = utc.TryParseDateTime();
            var result = time.LocalTimeToZonedDateTime(zone);
            return TestHelpers.GetTimeString(result);
        }

        [Test]
		[TestCaseSource("TimeZoneUtility_LocalTimeToZonedDateTime_TestCases")]
		public static string TimeZoneUtility_LocalTimeToZonedDateTime(string utc, string zone)
        {
            var time = utc.ParseDateTime();
            var result = TimeZoneUtility.LocalTimeToZonedDateTime(time, zone);
            return TestHelpers.GetTimeString(result);
        }

        [Test]
        [TestCase(null, "America/Denver", Result = null)]
		[TestCaseSource("TimeZoneUtility_LocalTimeToZonedDateTime_TestCases")]
		public static string TimeZoneUtility_LocalTimeToZonedDateTime_nullable(string utc, string zone)
        {
            var time = utc.TryParseDateTime();
            var result = TimeZoneUtility.LocalTimeToZonedDateTime(time, zone);
            return TestHelpers.GetTimeString(result);
        }
        #endregion
    }
}
