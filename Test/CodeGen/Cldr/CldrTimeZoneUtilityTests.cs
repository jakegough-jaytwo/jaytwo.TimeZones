using jaytwo.TimeZones.CodeGen.Cldr;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaytwo.TimeZones.Test.CodeGen.Cldr
{
	[TestFixture]
	public static class CldrTimeZoneUtilityTests
	{		
		[Test]
		[TestCase(null, Result = null)]
		[TestCase("", Result = null)]
		[TestCase("aqams", Result = "Pacific/Auckland")]
		[TestCase("usden", Result = "America/Denver")]
		public static string CldrTimeZoneUtility_GetOlsonTimeZone(string cldrTimeZoneKeyName)
		{
			return CldrTimeZoneUtility.GetOlsonTimeZone(cldrTimeZoneKeyName);
		}

		[Test]
		public static void CldrTimeZoneUtility_GetOlsonTimeZone_coverage()
		{
			var cldrTimeZoneKeys = CldrTimeZoneKeyParser.GetCldrTimeZoneKeys();
			foreach (var key in cldrTimeZoneKeys)
			{
				var olson = CldrTimeZoneUtility.GetOlsonTimeZone(key.Name);
				Assert.IsNotNullOrEmpty(olson);
			}
		}

		[Test]
		[TestCase("aqams", Result = "Pacific/Auckland")]
		[TestCase("usden", Result = "America/Denver")]
		public static string CldrTimeZoneUtility_CreateCldrTimeZoneKeyToOlsonTimeZoneMap(string cldrTimeZoneKeyName)
		{
			return CldrTimeZoneUtility.CreateCldrTimeZoneKeyToOlsonTimeZoneMap()
				.Single(x => x.First() == cldrTimeZoneKeyName)
				.Last();
		}
	}
}
