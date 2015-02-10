using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GoogleTimeZoneScraper
{
	public static class HybridThing
	{
		public static IList<HybridResultItem> GetHybridResultItems()
		{
			var timeZoneLocations = TimeZoneFetcher.ParseGoogleCalendarFetchTz();
			var countries = GeoNames.GetGeoNamesCountry();
			
			return GetHybridResultItems(timeZoneLocations, countries);			
		}

		public static IList<HybridResultItem> GetHybridResultItems(IList<TimeZoneLocation> timeZoneLocations, IList<GeoNamesCountry> countries)
		{
			return getHybridResultItemsAsEnumerable(timeZoneLocations, countries).ToList();
		}

		private static IEnumerable<HybridResultItem> getHybridResultItemsAsEnumerable(IList<TimeZoneLocation> timeZoneLocations, IList<GeoNamesCountry> countries)
		{
			foreach (var timeZoneLocation in timeZoneLocations)
			{
				var resultItem = new HybridResultItem();
				resultItem.CountryCode = timeZoneLocation.CountryCode;
				resultItem.TimeZone = timeZoneLocation.TimeZone;
				resultItem.TimeZoneDisplayText = timeZoneLocation.DisplayText;
				resultItem.Id = GetId(resultItem.CountryCode, resultItem.TimeZone);

				var country = countries.SingleOrDefault(x => x.ISO == timeZoneLocation.CountryCode);

				if (country != null)
				{
					resultItem.CountryName = country.Country;
				}
				else
				{
					resultItem.CountryName = "(None)";
				}
				
				yield return resultItem;
			}

		}

		private static string GetId(string countryCode, string timeZone)
		{
			var combined = string.Format("{0}_{1}", countryCode, timeZone);
			var safe = Regex.Replace(combined, "[^A-Za-z]", "_");
			return safe;
		}
	}
}
