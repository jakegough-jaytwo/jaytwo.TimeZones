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
    public static class CldrTimeZoneKeyParserTests
    {
        [Test]
        public static void CldrTimeZoneKeyParser_GetCldrTimeZoneKeys()
        {
            var result = CldrTimeZoneKeyParser.GetCldrTimeZoneKeys();
            Assert.IsNotNull(result);
            CollectionAssert.IsNotEmpty(result);
        }

		//[Test]
		//public static void CldrTimeZoneKey_aliases_are_all_valid_olson_time_zones()
		//{
		//	var pass = true;

		//	var cldrKeys = CldrTimeZoneKeyParser.GetCldrTimeZoneKeys();
		//	var cldrKeyAliases = cldrKeys.SelectMany(x => x.Aliases).ToList();
		//	var olsonTimeZones = TimeZoneUtility.GetOlsonTimeZones();

		//	foreach (var alias in cldrKeyAliases)
		//	{
		//		var matchingTimeZone = olsonTimeZones.SingleOrDefault(x => x == alias);

		//		if (matchingTimeZone == null)
		//		{
		//			Console.WriteLine("Unmatched CLDR Time Zone Alias: " + alias);
		//			pass = false;
		//		}
		//	}

		//	if (!pass)
		//	{
		//		Assert.Fail();
		//	}
		//}

		//[Test]
		//public static void CldrTimeZoneKey_all_olson_time_zones_can_map_to_cldr_keys()
		//{
		//	var cldrKeys = CldrTimeZoneKeyParser.GetCldrTimeZoneKeys();
		//	var olsonTimeZones = TimeZoneUtility.GetOlsonTimeZones();

		//	var pass = true;

		//	foreach (var olsonTimeZone in olsonTimeZones)
		//	{
		//		var matchingId = cldrKeys.SingleOrDefault(x => x.Aliases.Any(y => y == olsonTimeZone));

		//		if (matchingId == null)
		//		{
		//			Console.WriteLine("Unmatched olson zone: " + olsonTimeZone);
		//			pass = false;
		//		}
		//	}

		//	if (!pass)
		//	{
		//		Assert.Fail();
		//	}
		//}

		[Test]
		public static void CldrTimeZoneKey_aliases_contain_no_empty_strings()
		{
			var cldrKeys = CldrTimeZoneKeyParser.GetCldrTimeZoneKeys();
			var emptyStringAliasCount = cldrKeys
				.SelectMany(x => x.Aliases)
				.Count(x => string.IsNullOrEmpty(x));

			Assert.AreEqual(0, emptyStringAliasCount);
		}

		[Test]
		public static void CldrTimeZoneKey_aliases_are_unique()
		{
			var cldrKeys = CldrTimeZoneKeyParser.GetCldrTimeZoneKeys();

			var duplicates = cldrKeys
				.SelectMany(x => x.Aliases)
				.GroupBy(x => x)
				.Where(x => x.Count() > 1)
				.Select(x => x.First())
				.ToList();

			Assert.AreEqual(0, duplicates.Count);
		}
    }
}
