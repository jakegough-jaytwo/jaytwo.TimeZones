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
    public static class ZonedDateTimeExtensionsTests
    {
        #region InUtc
        private static IEnumerable<TestCaseData> ZonedDateTimeExtensions_InUtc_TestCases()
        {
            yield return new TestCaseData("2014-01-01T02:00:00", "usden").Returns("2014-01-01T09:00:00");
            yield return new TestCaseData("2014-01-01T02:00:00", "America/Denver").Returns("2014-01-01T09:00:00");
        }

        [Test]
        [TestCaseSource("ZonedDateTimeExtensions_InUtc_TestCases")]
        public static string ZonedDateTimeExtensions_InUtc(string localTime, string zone)
        {
            var zoned = localTime.ParseDateTime().LocalTimeToZonedDateTime(zone);
            var result = zoned.InUtc();
            return TestHelpers.GetTimeString(result);
        }

        [Test]
        [TestCase(null, "America/Denver", Result = null)]
        [TestCaseSource("ZonedDateTimeExtensions_InUtc_TestCases")]
        public static string ZonedDateTimeExtensions_InUtc_nullable(string localTime, string zone)
        {
            var zoned = localTime.TryParseDateTime().LocalTimeToZonedDateTime(zone);
            var result = zoned.InUtc();
            return TestHelpers.GetTimeString(result);
        }
        #endregion

        #region InZone
        private static IEnumerable<TestCaseData> ZonedDateTimeExtensions_InZone_TestCases()
        {
            yield return new TestCaseData("2014-01-01T02:00:00", null).Throws(typeof(ArgumentNullException));
            yield return new TestCaseData("2014-01-01T02:00:00", string.Empty).Throws(typeof(ArgumentNullException));
            yield return new TestCaseData("2014-01-01T09:00:00", "usden").Returns("2014-01-01T02:00:00");
            yield return new TestCaseData("2014-01-01T09:00:00", "America/Denver").Returns("2014-01-01T02:00:00");
        }

        [Test]
        [TestCaseSource("ZonedDateTimeExtensions_InZone_TestCases")]
        public static string TimeZoneUtility_ConvertTimeZone_ZonedDateTime(string utc, string zone)
        {
            var zoned = utc.ParseDateTime().UtcToZonedDateTime();
            var result = TimeZoneUtility.ConvertTimeZone(zoned, zone);
            return TestHelpers.GetTimeString(result);
        }

        [Test]
        [TestCase(null, "America/Denver", Result = null)]
        [TestCaseSource("ZonedDateTimeExtensions_InZone_TestCases")]
        public static string TimeZoneUtility_ConvertTimeZone_ZonedDateTime_nullable(string utc, string zone)
        {
            var zoned = utc.TryParseDateTime().UtcToZonedDateTime();
            var result = TimeZoneUtility.ConvertTimeZone(zoned, zone);
            return TestHelpers.GetTimeString(result);
        }

        [Test]
        [TestCaseSource("ZonedDateTimeExtensions_InZone_TestCases")]
        public static string ZonedDateTimeExtensions_InZone(string utc, string zone)
        {
            var zoned = utc.ParseDateTime().UtcToZonedDateTime();
            var result = zoned.InZone(zone);
            return TestHelpers.GetTimeString(result);
        }

        [Test]
        [TestCase(null, "America/Denver", Result = null)]
        [TestCaseSource("ZonedDateTimeExtensions_InZone_TestCases")]
        public static string ZonedDateTimeExtensions_InZone_nullable(string utc, string zone)
        {
            var zoned = utc.TryParseDateTime().UtcToZonedDateTime();
            var result = zoned.InZone(zone);
            return TestHelpers.GetTimeString(result);
        }
        #endregion

        #region ToUtcTimeIso8601String
        private static IEnumerable<TestCaseData> ZonedDateTimeExtensions_ToUtcTimeIso8601String_TestCases()
        {
            yield return new TestCaseData("2014-01-01T02:00:00", null).Throws(typeof(ArgumentNullException));
            yield return new TestCaseData("2014-01-01T02:00:00", string.Empty).Throws(typeof(ArgumentNullException));
            yield return new TestCaseData("2014-01-01T02:00:00", "usden").Returns("2014-01-01T09:00:00Z");
            yield return new TestCaseData("2014-01-01T02:00:00", "America/Denver").Returns("2014-01-01T09:00:00Z");
        }

        [Test]
        [TestCaseSource("ZonedDateTimeExtensions_ToUtcTimeIso8601String_TestCases")]
        public static string TimeZoneUtility_GetUtcTimeIso8601String(string localTime, string zone)
        {
            var zoned = localTime.ParseDateTime().LocalTimeToZonedDateTime(zone);
            return TimeZoneUtility.GetUtcTimeIso8601String(zoned);
        }

        [Test]
        [TestCase(null, "America/Denver", Result = null)]
        [TestCaseSource("ZonedDateTimeExtensions_ToUtcTimeIso8601String_TestCases")]
        public static string TimeZoneUtility_GetUtcTimeIso8601String_nullable(string localTime, string zone)
        {
            var zoned = localTime.TryParseDateTime().LocalTimeToZonedDateTime(zone);
            return TimeZoneUtility.GetUtcTimeIso8601String(zoned);
        }

        [Test]
        [TestCaseSource("ZonedDateTimeExtensions_ToUtcTimeIso8601String_TestCases")]
        public static string ZonedDateTimeExtensions_ToUtcTimeIso8601String(string localTime, string zone)
        {
            var zoned = localTime.ParseDateTime().LocalTimeToZonedDateTime(zone);
            return zoned.ToUtcTimeIso8601String();
        }

        [Test]
        [TestCase(null, "America/Denver", Result = null)]
        [TestCaseSource("ZonedDateTimeExtensions_ToUtcTimeIso8601String_TestCases")]
        public static string ZonedDateTimeExtensions_ToUtcTimeIso8601String_nullable(string localTime, string zone)
        {
            var zoned = localTime.TryParseDateTime().LocalTimeToZonedDateTime(zone);
            return zoned.ToUtcTimeIso8601String();
        }
        #endregion

        #region ToDateTimeUtc
        private static IEnumerable<TestCaseData> ZonedDateTimeExtensions_ToDateTimeUtc_nullable_TestCases()
        {
            yield return new TestCaseData("2014-01-01T02:00:00", null).Throws(typeof(ArgumentNullException));
            yield return new TestCaseData("2014-01-01T02:00:00", string.Empty).Throws(typeof(ArgumentNullException));
            yield return new TestCaseData("2014-01-01T02:00:00", "usden").Returns("2014-01-01T09:00:00");
            yield return new TestCaseData("2014-01-01T02:00:00", "America/Denver").Returns("2014-01-01T09:00:00");
        }

        [Test]
        [TestCase(null, "America/Denver", Result = null)]
        [TestCaseSource("ZonedDateTimeExtensions_ToDateTimeUtc_nullable_TestCases")]
        public static string ZonedDateTimeExtensions_ToDateTimeUtc_nullable(string localTime, string zone)
        {
            var zoned = localTime.TryParseDateTime().LocalTimeToZonedDateTime(zone);
            var result = zoned.ToDateTimeUtc();
            return TestHelpers.GetTimeString(result);
        }
        #endregion

        #region ToInstant
        private static IEnumerable<TestCaseData> ZonedDateTimeExtensions_ToInstant_nullable_TestCases()
        {
            yield return new TestCaseData("2014-01-01T02:00:00", null).Throws(typeof(ArgumentNullException));
            yield return new TestCaseData("2014-01-01T02:00:00", string.Empty).Throws(typeof(ArgumentNullException));
            yield return new TestCaseData("2014-01-01T02:00:00", "usden").Returns("2014-01-01T09:00:00");
            yield return new TestCaseData("2014-01-01T02:00:00", "America/Denver").Returns("2014-01-01T09:00:00");
        }

        [Test]
        [TestCase(null, "America/Denver", Result = null)]
        [TestCaseSource("ZonedDateTimeExtensions_ToInstant_nullable_TestCases")]
        public static string ZonedDateTimeExtensions_ToInstant_nullable(string localTime, string zone)
        {
            var zoned = localTime.TryParseDateTime().LocalTimeToZonedDateTime(zone);
            var result = zoned.ToInstant();
            return TestHelpers.GetTimeString(result);
        }
        #endregion

        #region TruncateToSecondPrecision
        private static IEnumerable<TestCaseData> NodaTimeHelpers_TruncateToSecondPrecision_TestCases()
        {
            yield return new TestCaseData("2014-01-02T13:34:45.56").Returns("2014-01-02T13:34:45");
        }

        [Test]
        [TestCaseSource("NodaTimeHelpers_TruncateToSecondPrecision_TestCases")]
        public static string NodaTimeHelpers_TruncateToSecondPrecision(string value)
        {
            var date = value.ParseDateTime().UtcToZonedDateTime();
            var result = NodaTimeHelpers.TruncateToSecondPrecision(date).ToDateTimeUnspecified();
            return TestHelpers.GetTimeString(result);
        }

        [Test]
        [TestCase(null, Result = null)]
        [TestCaseSource("NodaTimeHelpers_TruncateToSecondPrecision_TestCases")]
        public static string NodaTimeHelpers_TruncateToSecondPrecision_nullable(string value)
        {
            var date = value.TryParseDateTime().UtcToZonedDateTime();
            var result = NodaTimeHelpers.TruncateToSecondPrecision(date).ToDateTimeUnspecified();
            return TestHelpers.GetTimeString(result);
        }

        [Test]
        [TestCaseSource("NodaTimeHelpers_TruncateToSecondPrecision_TestCases")]
        public static string ZonedDateTimeExtensions_TruncateToSecondPrecision(string value)
        {
            var date = value.ParseDateTime().UtcToZonedDateTime();
            var result = date.TruncateToSecondPrecision().ToDateTimeUnspecified();
            return TestHelpers.GetTimeString(result);
        }

        [Test]
        [TestCase(null, Result = null)]
        [TestCaseSource("NodaTimeHelpers_TruncateToSecondPrecision_TestCases")]
        public static string ZonedDateTimeExtensions_TruncateToSecondPrecision_nullable(string value)
        {
            var date = value.TryParseDateTime().UtcToZonedDateTime();
            var result = date.TruncateToSecondPrecision().ToDateTimeUnspecified();
            return TestHelpers.GetTimeString(result);
        }
        #endregion

        #region TruncateToMinutePrecision
        private static IEnumerable<TestCaseData> NodaTimeHelpers_TruncateToMinutePrecision_TestCases()
        {
            yield return new TestCaseData("2014-01-02T13:34:45.56").Returns("2014-01-02T13:34:00");
        }

        [Test]
        [TestCaseSource("NodaTimeHelpers_TruncateToMinutePrecision_TestCases")]
        public static string NodaTimeHelpers_TruncateToMinutePrecision(string value)
        {
            var date = value.ParseDateTime().UtcToZonedDateTime();
            var result = NodaTimeHelpers.TruncateToMinutePrecision(date).ToDateTimeUnspecified();
            return TestHelpers.GetTimeString(result);
        }

        [Test]
        [TestCase(null, Result = null)]
        [TestCaseSource("NodaTimeHelpers_TruncateToMinutePrecision_TestCases")]
        public static string NodaTimeHelpers_TruncateToMinutePrecision_nullable(string value)
        {
            var date = value.TryParseDateTime().UtcToZonedDateTime();
            var result = NodaTimeHelpers.TruncateToMinutePrecision(date).ToDateTimeUnspecified();
            return TestHelpers.GetTimeString(result);
        }

        [Test]
        [TestCaseSource("NodaTimeHelpers_TruncateToMinutePrecision_TestCases")]
        public static string ZonedDateTimeExtensions_TruncateToMinutePrecision(string value)
        {
            var date = value.ParseDateTime().UtcToZonedDateTime();
            var result = date.TruncateToMinutePrecision().ToDateTimeUnspecified();
            return TestHelpers.GetTimeString(result);
        }

        [Test]
        [TestCase(null, Result = null)]
        [TestCaseSource("NodaTimeHelpers_TruncateToMinutePrecision_TestCases")]
        public static string ZonedDateTimeExtensions_TruncateToMinutePrecision_nullable(string value)
        {
            var date = value.TryParseDateTime().UtcToZonedDateTime();
            var result = date.TruncateToMinutePrecision().ToDateTimeUnspecified();
            return TestHelpers.GetTimeString(result);
        }
        #endregion
    }
}
