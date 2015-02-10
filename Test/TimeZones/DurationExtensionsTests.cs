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
    public static class DurationExtensionsTests
    {
        private static Duration GetDuration(TimeSpan value)
        {
            return Duration.FromTimeSpan(value);
        }

        private static Duration? GetDuration(TimeSpan? value)
        {
            if (value.HasValue)
            {
                return Duration.FromTimeSpan(value.Value);
            }
            else
            {
                return null;
            }
        }

        #region GetTotalDays
        private static IEnumerable<TestCaseData> GetTotalDays_TestCases()
        {
            yield return new TestCaseData(TimeSpan.FromHours(12)).Returns(0.5d);
            yield return new TestCaseData(TimeSpan.FromHours(24)).Returns(1d);
            yield return new TestCaseData(TimeSpan.FromHours(36)).Returns(1.5d);
            yield return new TestCaseData(TimeSpan.FromHours(48)).Returns(2d);
        }

        [Test]
        [TestCaseSource("GetTotalDays_TestCases")]
        public static double NodaTimeHelpers_GetTotalDays(TimeSpan timespan)
        {
            return NodaTimeHelpers.GetTotalDays(GetDuration(timespan));
        }

        [Test]
        [TestCaseSource("GetTotalDays_TestCases")]
        [TestCase(null, Result = null)]
        public static double? NodaTimeHelpers_GetTotalDays_Nullable(TimeSpan? timespan)
        {
            return NodaTimeHelpers.GetTotalDays(GetDuration(timespan));
        }

        [Test]
        [TestCaseSource("GetTotalDays_TestCases")]
        public static double DurationExtensions_GetTotalDays(TimeSpan timespan)
        {
            return GetDuration(timespan).GetTotalDays();
        }

        [Test]
        [TestCaseSource("GetTotalDays_TestCases")]
        [TestCase(null, Result = null)]
        public static double? DurationExtensions_GetTotalDays_Nullable(TimeSpan? timespan)
        {
            return GetDuration(timespan).GetTotalDays();
        }
        #endregion

        #region GetTotalHours
        private static IEnumerable<TestCaseData> GetTotalHours_TestCases()
        {
            yield return new TestCaseData(TimeSpan.FromMinutes(30)).Returns(0.5d);
            yield return new TestCaseData(TimeSpan.FromMinutes(60)).Returns(1d);
            yield return new TestCaseData(TimeSpan.FromMinutes(90)).Returns(1.5d);
            yield return new TestCaseData(TimeSpan.FromMinutes(120)).Returns(2d);
        }

        [Test]
        [TestCaseSource("GetTotalHours_TestCases")]
        public static double NodaTimeHelpers_GetTotalHours(TimeSpan timespan)
        {
            return NodaTimeHelpers.GetTotalHours(GetDuration(timespan));
        }

        [Test]
        [TestCaseSource("GetTotalHours_TestCases")]
        [TestCase(null, Result = null)]
        public static double? NodaTimeHelpers_GetTotalHours_Nullable(TimeSpan? timespan)
        {
            return NodaTimeHelpers.GetTotalHours(GetDuration(timespan));
        }

        [Test]
        [TestCaseSource("GetTotalHours_TestCases")]
        public static double DurationExtensions_GetTotalHours(TimeSpan timespan)
        {
            return GetDuration(timespan).GetTotalHours();
        }

        [Test]
        [TestCaseSource("GetTotalHours_TestCases")]
        [TestCase(null, Result = null)]
        public static double? DurationExtensions_GetTotalHours_Nullable(TimeSpan? timespan)
        {
            return GetDuration(timespan).GetTotalHours();
        }
        #endregion

        #region GetTotalMinutes
        private static IEnumerable<TestCaseData> GetTotalMinutes_TestCases()
        {
            yield return new TestCaseData(TimeSpan.FromSeconds(30)).Returns(0.5d);
            yield return new TestCaseData(TimeSpan.FromSeconds(60)).Returns(1d);
            yield return new TestCaseData(TimeSpan.FromSeconds(90)).Returns(1.5d);
            yield return new TestCaseData(TimeSpan.FromSeconds(120)).Returns(2d);
        }

        [Test]
        [TestCaseSource("GetTotalMinutes_TestCases")]
        public static double NodaTimeHelpers_GetTotalMinutes(TimeSpan timespan)
        {
            return NodaTimeHelpers.GetTotalMinutes(GetDuration(timespan));
        }

        [Test]
        [TestCaseSource("GetTotalMinutes_TestCases")]
        [TestCase(null, Result = null)]
        public static double? NodaTimeHelpers_GetTotalMinutes_Nullable(TimeSpan? timespan)
        {
            return NodaTimeHelpers.GetTotalMinutes(GetDuration(timespan));
        }

        [Test]
        [TestCaseSource("GetTotalMinutes_TestCases")]
        public static double DurationExtensions_GetTotalMinutes(TimeSpan timespan)
        {
            return GetDuration(timespan).GetTotalMinutes();
        }

        [Test]
        [TestCaseSource("GetTotalMinutes_TestCases")]
        [TestCase(null, Result = null)]
        public static double? DurationExtensions_GetTotalMinutes_Nullable(TimeSpan? timespan)
        {
            return GetDuration(timespan).GetTotalMinutes();
        }
        #endregion

        #region GetTotalSeconds
        private static IEnumerable<TestCaseData> GetTotalSeconds_TestCases()
        {
            yield return new TestCaseData(TimeSpan.FromMilliseconds(500)).Returns(0.5d);
            yield return new TestCaseData(TimeSpan.FromMilliseconds(1000)).Returns(1d);
            yield return new TestCaseData(TimeSpan.FromMilliseconds(1500)).Returns(1.5d);
            yield return new TestCaseData(TimeSpan.FromMilliseconds(2000)).Returns(2d);
        }

        [Test]
        [TestCaseSource("GetTotalSeconds_TestCases")]
        public static double NodaTimeHelpers_GetTotalSeconds(TimeSpan timespan)
        {
            return NodaTimeHelpers.GetTotalSeconds(GetDuration(timespan));
        }

        [Test]
        [TestCaseSource("GetTotalSeconds_TestCases")]
        [TestCase(null, Result = null)]
        public static double? NodaTimeHelpers_GetTotalSeconds_Nullable(TimeSpan? timespan)
        {
            return NodaTimeHelpers.GetTotalSeconds(GetDuration(timespan));
        }

        [Test]
        [TestCaseSource("GetTotalSeconds_TestCases")]
        public static double DurationExtensions_GetTotalSeconds(TimeSpan timespan)
        {
            return GetDuration(timespan).GetTotalSeconds();
        }

        [Test]
        [TestCaseSource("GetTotalSeconds_TestCases")]
        [TestCase(null, Result = null)]
        public static double? DurationExtensions_GetTotalSeconds_Nullable(TimeSpan? timespan)
        {
            return GetDuration(timespan).GetTotalSeconds();
        }
        #endregion

        #region GetTotalMilliseconds
        private static IEnumerable<TestCaseData> GetTotalMilliseconds_TestCases()
        {
            yield return new TestCaseData(TimeSpan.FromMilliseconds(500)).Returns(500d);
            yield return new TestCaseData(TimeSpan.FromMilliseconds(1000)).Returns(1000d);
            yield return new TestCaseData(TimeSpan.FromMilliseconds(1500)).Returns(1500d);
            yield return new TestCaseData(TimeSpan.FromMilliseconds(2000)).Returns(2000d);
        }

        [Test]
        [TestCaseSource("GetTotalMilliseconds_TestCases")]
        public static double NodaTimeHelpers_GetTotalMilliseconds(TimeSpan timespan)
        {
            return NodaTimeHelpers.GetTotalMilliseconds(GetDuration(timespan));
        }

        [Test]
        [TestCaseSource("GetTotalMilliseconds_TestCases")]
        [TestCase(null, Result = null)]
        public static double? NodaTimeHelpers_GetTotalMilliseconds_Nullable(TimeSpan? timespan)
        {
            return NodaTimeHelpers.GetTotalMilliseconds(GetDuration(timespan));
        }

        [Test]
        [TestCaseSource("GetTotalMilliseconds_TestCases")]
        public static double DurationExtensions_GetTotalMilliseconds(TimeSpan timespan)
        {
            return GetDuration(timespan).GetTotalMilliseconds();
        }

        [Test]
        [TestCaseSource("GetTotalMilliseconds_TestCases")]
        [TestCase(null, Result = null)]
        public static double? DurationExtensions_GetTotalMilliseconds_Nullable(TimeSpan? timespan)
        {
            return GetDuration(timespan).GetTotalMilliseconds();
        }
        #endregion
    }
}
