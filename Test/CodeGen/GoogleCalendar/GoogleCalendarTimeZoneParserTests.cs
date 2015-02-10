using jaytwo.TimeZones.CodeGen.GoogleCalendar;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaytwo.TimeZones.Test.CodeGen.GoogleCalendar
{
    [TestFixture]
    public static class GoogleCalendarTimeZoneParserTests
    {
        [Test]
        public static void GoogleCalendarTimeZoneParser_GetGoogleCalendarTimeZones()
        {
            var result = GoogleCalendarTimeZoneParser.GetGoogleCalendarTimeZones();
            Assert.IsNotNull(result);
            CollectionAssert.IsNotEmpty(result);            
        }
    }
}
