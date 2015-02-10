using NodaTime;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rhino.Mocks;
using jaytwo.Common;
using jaytwo.Common.Extensions;
using jaytwo.TimeZones;
using jaytwo.Common.Time;

namespace jaytwo.TimeZones.Test.TimeZones
{
    [TestFixture]
    public static class TimeZoneUtilityTests
	{

		#region IsDaylightSavingTimeAtLocalTime
		private static IEnumerable<TestCaseData> TimeZoneUtility_IsDaylightSavingTimeAtLocalTime_TestCases()
        {
            yield return new TestCaseData("2014-01-01T12:00:00", null).Throws(typeof(ArgumentNullException));
            yield return new TestCaseData("2014-01-01T12:00:00", "usnyc").Returns(false);
            yield return new TestCaseData("2014-01-01T12:00:00", "America/Denver").Returns(false);
            yield return new TestCaseData("2014-06-01T12:00:00", "America/Denver").Returns(true);
            yield return new TestCaseData("2014-03-09T01:59:59", "America/Denver").Returns(false);
            yield return new TestCaseData("2014-03-09T02:00:00", "America/Denver").Returns(true); // technically 2:00 doesn't exist, but if it did....
            yield return new TestCaseData("2014-03-09T03:00:00", "America/Denver").Returns(true); // 1:59 ticks to 3:00
            yield return new TestCaseData("2014-11-02T00:59:59", "America/Denver").Returns(true);
            yield return new TestCaseData("2014-11-02T01:59:59", "America/Denver").Returns(false); // technically 1:00-1:59 happens twice, but if it didn't....
            yield return new TestCaseData("2014-11-02T02:00:00", "America/Denver").Returns(false);
        }

        [Test]
		[TestCaseSource("TimeZoneUtility_IsDaylightSavingTimeAtLocalTime_TestCases")]
		public static bool TimeZoneUtility_IsDaylightSavingTimeAtLocalTime(string value, string zone)
        {
            var time = value.ParseDateTime();
            return TimeZoneUtility.IsDaylightSavingTimeAtLocalTime(time, zone);
        }
        #endregion

		#region IsDaylightSavingTimeAtUtc
		private static IEnumerable<TestCaseData> TimeZoneUtility_IsDaylightSavingTimeAtUtc_TestCases()
		{
			yield return new TestCaseData("2014-01-01T20:00:00", null).Throws(typeof(ArgumentNullException));
			yield return new TestCaseData("2014-01-01T20:00:00", string.Empty).Throws(typeof(ArgumentNullException));
			yield return new TestCaseData("2014-01-01T20:00:00", "usnyc").Returns(false);
			yield return new TestCaseData("2014-01-01T20:00:00", "America/New_York").Returns(false);
			yield return new TestCaseData("2014-06-01T20:00:00", "America/New_York").Returns(true);
			yield return new TestCaseData("2014-03-09T06:59:59", "America/New_York").Returns(false);  // 1:59 am eastern = 6:59 am utc
			yield return new TestCaseData("2014-03-09T07:00:00", "America/New_York").Returns(true);   // 3:00 am eastern = 7:00 am utc
			yield return new TestCaseData("2014-11-02T05:59:59", "America/New_York").Returns(true);   // 1:59 am eastern = 5:59 am utc (but it's the fist 1 am)
			yield return new TestCaseData("2014-11-02T06:00:00", "America/New_York").Returns(false);  // 1:00 am eastern = 6:00 am utc (but it's the second 1 am)
		}

		[Test]
		[TestCaseSource("TimeZoneUtility_IsDaylightSavingTimeAtUtc_TestCases")]
		public static bool TimeZoneUtility_IsDaylightSavingTimeAtUtc(string value, string zone)
		{
			var time = value.ParseDateTime();
			return TimeZoneUtility.IsDaylightSavingTimeAtUtc(time, zone);
		}
		#endregion

        #region GetTimeZoneUtcOffsetAtUtc
        static IEnumerable<TestCaseData> GetTimeZoneUtcOffsetAtUtc_TestCaseData()
        {
            yield return new TestCaseData("2014-01-01T20:00:00", null).Throws(typeof(ArgumentNullException));
            yield return new TestCaseData("2014-01-01T20:00:00", string.Empty).Throws(typeof(ArgumentNullException));
            yield return new TestCaseData("2014-01-01T20:00:00", "usnyc").Returns(-5);
            yield return new TestCaseData("2014-01-01T20:00:00", "America/New_York").Returns(-5);
            yield return new TestCaseData("2014-06-01T20:00:00", "America/New_York").Returns(-4);
            yield return new TestCaseData("2014-03-09T06:59:59", "America/New_York").Returns(-5); // 1:59 am eastern = 6:59 am utc
            yield return new TestCaseData("2014-03-09T07:00:00", "America/New_York").Returns(-4); // 3:00 am eastern = 7:00 am utc
            yield return new TestCaseData("2014-11-02T05:59:59", "America/New_York").Returns(-4); // 1:59 am eastern = 5:59 am utc (but it's the fist 1 am)
            yield return new TestCaseData("2014-11-02T06:00:00", "America/New_York").Returns(-5); // 1:00 am eastern = 6:00 am utc (but it's the second 1 am)
        }

        [Test]
        [TestCaseSource("GetTimeZoneUtcOffsetAtUtc_TestCaseData")]
        public static double TimeZoneUtility_GetTimeZoneUtcOffsetAtUtc(string value, string timeZone)
        {
            var time = value.ParseDateTime();
            var result = TimeZoneUtility.GetTimeZoneUtcOffsetAtUtc(time, timeZone);
            return result.TotalHours;
        }
        #endregion

        #region GetTimeZoneUtcOffsetAtLocalTime
        static IEnumerable<TestCaseData> GetTimeZoneUtcOffsetFromZoneLocalTime_TestCaseData()
        {
            yield return new TestCaseData("2014-01-01T20:00:00", "usnyc").Returns(-5); 
			yield return new TestCaseData("2014-01-01T20:00:00", "America/New_York").Returns(-5); 
            yield return new TestCaseData("2014-06-01T20:00:00", "America/New_York").Returns(-4);
			yield return new TestCaseData("2014-03-09T01:59:59", "America/New_York").Returns(-5);
            yield return new TestCaseData("2014-03-09T02:00:00", "America/New_York").Returns(-4); // 2:00 doesn't exist... we round up
            yield return new TestCaseData("2014-03-09T03:00:00", "America/New_York").Returns(-4);
            yield return new TestCaseData("2014-11-02T00:59:59", "America/New_York").Returns(-4);
            yield return new TestCaseData("2014-11-02T01:00:00", "America/New_York").Returns(-5); // 1:00-1:59 happens twice.... we round up
            yield return new TestCaseData("2014-11-02T02:00:00", "America/New_York").Returns(-5);
		}

        [Test]
        [TestCaseSource("GetTimeZoneUtcOffsetFromZoneLocalTime_TestCaseData")]
        public static double TimeZoneUtility_GetTimeZoneUtcOffsetAtLocalTime(string value, string timeZone)
        {
            var time = value.ParseDateTime();
            var result = TimeZoneUtility.GetTimeZoneUtcOffsetAtLocalTime(time, timeZone);
            return result.TotalHours;
        }
        #endregion

        #region GetTimeZoneObservesDaylightSavingTime
        private static IEnumerable<TestCaseData> TimeZoneUtility_GetTimeZoneObservesDaylightSavingTime_TestCases()
        {
            yield return new TestCaseData(null).Throws(typeof(ArgumentNullException));
            yield return new TestCaseData(string.Empty).Throws(typeof(ArgumentNullException));
            yield return new TestCaseData("usden").Returns(true);
            yield return new TestCaseData("America/Denver").Returns(true);
            yield return new TestCaseData("America/Phoenix").Returns(false);
            yield return new TestCaseData("Etc/GMT").Returns(false);
        }

        [Test]
        [TestCaseSource("TimeZoneUtility_GetTimeZoneObservesDaylightSavingTime_TestCases")]
        public static bool TimeZoneUtility_GetTimeZoneObservesDaylightSavingTime(string timeZone)
        {
            return TimeZoneUtility.TimeZoneObservesDaylightSavingTime(timeZone);
        }
        #endregion

        #region GetNextDaylightSavingBoundary
        private static IEnumerable<TestCaseData> TimeZoneUtility_GetNextDaylightSavingBoundary_TestCases()
        {
            yield return new TestCaseData("2014-01-02T13:34:45.56", null).Throws(typeof(ArgumentNullException));
            yield return new TestCaseData("2014-01-02T13:34:45.56", string.Empty).Throws(typeof(ArgumentNullException));
            yield return new TestCaseData("2014-01-02T13:34:45.56", "usden").Returns("2014-03-09T03:00:00");
            yield return new TestCaseData("2014-01-02T13:34:45.56", "America/Denver").Returns("2014-03-09T03:00:00");
            yield return new TestCaseData("2014-06-02T13:34:45.56", "America/Denver").Returns("2014-11-02T01:00:00");
            yield return new TestCaseData("2014-01-02T13:34:45.56", "America/Phoenix").Returns(null);
            yield return new TestCaseData("2014-01-02T13:34:45.56", "Etc/GMT").Returns(null);
        }

        [Test]
        [TestCaseSource("TimeZoneUtility_GetNextDaylightSavingBoundary_TestCases")]
        public static string TimeZoneUtility_GetNextDaylightSavingBoundary(string value, string timeZone)
        {
            var date = value.ParseDateTime();
            var result = TimeZoneUtility.GetNextDaylightSavingBoundary(date, timeZone);
            return TestHelpers.GetTimeString(result);
        }
        #endregion

    }
}
