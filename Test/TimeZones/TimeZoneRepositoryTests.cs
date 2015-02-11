using jaytwo.TimeZones;
using jaytwo.TimeZones.CodeGen;
using jaytwo.TimeZones.CodeGen.Cldr;
using jaytwo.TimeZones.CodeGen.GeoNames;
using jaytwo.TimeZones.CodeGen.GoogleCalendar;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace jaytwo.TimeZones.Test.TimeZones
{
    [TestFixture]
    public static class TimeZoneRepositoryTests
    {
        [Test]
        public static void TimeZoneRepositoryInternal_TimeZones_up_to_date()
        {
            var serializer = new JavaScriptSerializer();

            var fromBuilder = ListItemBuilder.GetTimeZones()
                .Select(x => serializer.Serialize(x))
                .ToList();

            var fromRepository = TimeZoneRepositoryInternal.TimeZones
                .Select(x => serializer.Serialize(x))
                .ToList();
            CollectionAssert.AreEquivalent(fromBuilder, fromRepository);
        }

		[Test]
		public static void TimeZoneRepositoryInternal_Max_time_zone_length()
		{
			var maxIdLength = TimeZoneRepositoryInternal.TimeZones.Max(x => x.Id.Length);
			Console.WriteLine("Max time zone id length: {0}", maxIdLength);
			
			var maxIdLengthWithoutUnderscore = TimeZoneRepositoryInternal.TimeZones
				.Select(x => x.Id)
				.Where(x =>!x.Contains("_"))
				.Max(x => x.Length);
			Console.WriteLine("Max time zone id length without underscore: {0}", maxIdLengthWithoutUnderscore);

			var fiveDigitsCount = TimeZoneRepositoryInternal.TimeZones
				.Count(x => x.Id.Length <= 5);

			double fiveDigitPercentage = (double)fiveDigitsCount / (double)TimeZoneRepositoryInternal.TimeZones.Count();
			Console.WriteLine("percentage of ids with 5 digits or less: {0}", fiveDigitPercentage);

			var eightDigitsCount = TimeZoneRepositoryInternal.TimeZones
				.Count(x => x.Id.Length <= 8);

			double eightDigitPercentage = (double)eightDigitsCount / (double)TimeZoneRepositoryInternal.TimeZones.Count();
			Console.WriteLine("percentage of ids with 8 digits or less: {0}", eightDigitPercentage);
		}

        [Test]
        public static void TimeZoneRepositoryInternal_Countries_up_to_date()
        {
            var serializer = new JavaScriptSerializer();

            var fromBuilder = ListItemBuilder.GetCountries()
                .Select(x => serializer.Serialize(x))
                .ToList();

            var fromRepository = TimeZoneRepositoryInternal.Countries
                .Select(x => serializer.Serialize(x))
                .ToList();

            CollectionAssert.AreEquivalent(fromBuilder, fromRepository);
        }

        [Test]
        public static void TimeZoneRepositoryInternal_CldrTimeZoneKeyToOlsonTimeZoneMap_up_to_date()
        {
            var serializer = new JavaScriptSerializer();

            var fromBuilder = CldrTimeZoneUtility.CreateCldrTimeZoneKeyToOlsonTimeZoneMap()
                .Select(x => serializer.Serialize(x))
                .ToList();

            var fromRepository = TimeZoneRepositoryInternal.CldrTimeZoneKeyToOlsonTimeZoneMap
                .Select(x => new[] { x.Key, x.Value })
                .Select(x => serializer.Serialize(x))
                .ToList();

            CollectionAssert.AreEquivalent(fromBuilder, fromRepository);
        }

        [Test]
        public static void TimeZoneRepository_zz_country_code_is_last_in_list()
        {
            Assert.AreEqual("ZZ", TimeZoneRepository.Default.GetTimeZones().Last().CountryId);
            Assert.AreEqual("ZZ", TimeZoneRepository.Default.GetCountries().Last().Id);
        }

        [Test]
        public static void TimeZoneRepository_IsAssignedToCountry_only_applies_to_zz_country_codes()
        {
            var zzCountryCodes = TimeZoneRepository.Default.GetTimeZones().Where(x => x.CountryId == "ZZ");
            Assert.IsTrue(zzCountryCodes.All(x => !x.IsAssignedToCountry));

            var nonZzCountryCodes = TimeZoneRepository.Default.GetTimeZones().Where(x => x.CountryId != "ZZ");
            Assert.IsTrue(nonZzCountryCodes.All(x => x.IsAssignedToCountry));
        }

        [Test]
        public static void TimeZoneRepository_GetCountryIdFromTimeZoneListItemId()
        {
            var countries = GeoNamesCountryParser.GetGeoNamesCountries();

            var timeZonesAssignedToCountry = TimeZoneRepository.Default.GetTimeZones().Where(x => x.IsAssignedToCountry);

            foreach (var timeZone in timeZonesAssignedToCountry)
            {
                var countryCode = TimeZoneRepository.GetCountryIdFromTimeZoneListItemId(timeZone.Id);
                var matchingCountry = countries.Single(x => x.ISO == countryCode);
                Assert.AreEqual(countryCode, matchingCountry.ISO);
            }

            Assert.AreEqual(TimeZoneRepositoryInternal.CountryIndependentIsoCode, TimeZoneRepository.GetCountryIdFromTimeZoneListItemId("utc"));
        }

        [Test]
        public static void TimeZoneRepository_GetCldrTimeZoneKeyFromTimeZoneListItemId()
        {
            var timeZones = TimeZoneRepository.Default.GetTimeZones();

            foreach (var timeZone in timeZones)
            {
                var cldrTimeZoneKey = TimeZoneRepository.GetCldrTimeZoneKeyFromTimeZoneListItemId(timeZone.Id);
                Assert.AreEqual(timeZone.CldrTimeZoneKey, cldrTimeZoneKey);
            }
        }

        [Test]
        public static void TimeZoneLocationRepository_TimeZones_match_google()
        {
            var timeZones = TimeZoneRepository.Default.GetTimeZones();

            var googleCalendarTimeZones = GoogleCalendarTimeZoneParser.GetGoogleCalendarTimeZones();
            Assert.AreEqual(googleCalendarTimeZones.Count, timeZones.Count);

            var googleOlsonTimeZones = googleCalendarTimeZones.Select(x => x.OlsonTimeZone).ToList();
            var libraryOlsonTimeZones = timeZones.Select(x => x.OlsonTimeZone).ToList();

            CollectionAssert.AreEquivalent(googleOlsonTimeZones, libraryOlsonTimeZones);
        }

        [Test]
        public static void TimeZoneRepository_TimeZoneListItem_Id_is_unique()
        {
            var timeZones = TimeZoneRepository.Default.GetTimeZones();

            var duplicates = timeZones
                .GroupBy(x => x.Id)
                .Where(x => x.Count() > 1)
                .SelectMany(x => x)
                .ToList();

            Assert.AreEqual(0, duplicates.Count);
        }

        [Test]
        [TestCase("America/Denver", Result = "America/Denver")]
        [TestCase("usden", Result = "America/Denver")]
        [TestCase("usden_us", Result = "America/Denver")]
        [TestCase("afkbl", Result = "Asia/Kabul")]
        [TestCase("cnckg", Result = "Asia/Shanghai")]
        [TestCase("utc", Result = "Etc/GMT")]
        public static string TimeZoneRepositoryInternal_GetOlsonTimeZone(string timeZone)
        {
            return TimeZoneRepositoryInternal.GetTzdbId(timeZone);
        }

        [Test]
        public static void TimeZoneRepository_GetTimeZoneById()
        {
            var timeZone = TimeZoneRepository.Default.GetTimeZoneById("usden");
            Assert.AreEqual(timeZone.Id, "usden");
        }

        [Test]
        public static void TimeZoneRepository_GetTimeZonesByCountryIsoCode()
        {
            var timeZones = TimeZoneRepository.Default.GetTimeZonesByCountryId("US");
            CollectionAssert.IsNotEmpty(timeZones);
            Assert.IsTrue(timeZones.All(x => x.CountryId == "US"));
        }

        [Test]
        public static void TimeZoneRepository_GetCountryByIsoCode()
        {
            var country = TimeZoneRepository.Default.GetCountryById("US");
            Assert.AreEqual(country.Id, "US");
        }

        [Test]
        public static void TimeZoneRepository_ConsistencyTest()
        {
            var timeZones = TimeZoneRepository.Default.GetTimeZones();
            Assert.IsNotNull(timeZones);
            CollectionAssert.AllItemsAreNotNull(timeZones);

            var olsonTimeZonesSuperset = TimeZoneUtility.GetOlsonTimeZones();

            var olsonTimeZonesSubset = timeZones
                .Select(x => x.OlsonTimeZone)
                .Distinct()
                .ToList();

            CollectionAssert.IsSubsetOf(olsonTimeZonesSubset, olsonTimeZonesSuperset);

            Console.WriteLine("{0} olson time zones", olsonTimeZonesSubset.Count);

            var countrySuperset = GeoNamesCountryParser.GetGeoNamesCountries()
                .Select(x => x.ISO)
                .ToList();

            var timeZoneCountrySubset = timeZones
                .Where(x => x.IsAssignedToCountry)
                .Select(x => x.CountryId)
                .Distinct()
                .ToList();

            CollectionAssert.IsSubsetOf(timeZoneCountrySubset, countrySuperset);

            Console.WriteLine("{0} time zone countries", timeZoneCountrySubset.Count);

            var countries = TimeZoneRepository.Default.GetCountries();
            Assert.IsNotNull(countries);
            CollectionAssert.AllItemsAreNotNull(countries);

            var countrySubset = countries
                .Where(x => x.Id != "ZZ")
                .Select(x => x.Id)
                .Distinct()
                .ToList();

            CollectionAssert.IsSubsetOf(countrySubset, countrySuperset);

            Console.WriteLine("{0} countries", countrySubset.Count);
        }
    }
}
