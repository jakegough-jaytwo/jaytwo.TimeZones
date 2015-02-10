using jaytwo.TimeZones.CodeGen.GeoNames;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaytwo.TimeZones.Test.CodeGen.GeoNames
{
    [TestFixture]
    public static class GoogleCalendarTimeZoneParserTests
    {
        [Test]
        public static void GeoNamesCountryParser_GetGeoNamesCountries()
        {
            var result = GeoNamesCountryParser.GetGeoNamesCountries();
            Assert.IsNotNull(result);
            CollectionAssert.IsNotEmpty(result);
        }
    }
}
