using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jaytwo.TimeZones
{
	internal static partial class TimeZoneRepositoryInternal
	{
		public static readonly string CountryIndependentIsoCode = "ZZ";
		public static readonly string UtcCldrTimeZoneKey = "utc";

		public static IList<TimeZoneListItem> TimeZones { get; private set; }

		public static IList<CountryListItem> Countries { get; private set; }

		public static IDictionary<string, string> CldrTimeZoneKeyToOlsonTimeZoneMap { get; private set; }

		public static IDictionary<string, string> TimeZoneListItemIdToOlsonTimeZoneMap { get; private set; }

		static TimeZoneRepositoryInternal()
		{
			Countries = GetAllCountries()
				.OrderBy(x => x.Id == CountryIndependentIsoCode)
				.ThenBy(x => x.Name)
				.ToList()
				.AsReadOnly();

			TimeZones = GetAllTimeZones()
				.OrderBy(x => !x.IsAssignedToCountry)
				.ThenBy(x => x.DisplayNameWithCountry)
				.ToList()
				.AsReadOnly();

			TimeZoneListItemIdToOlsonTimeZoneMap = TimeZones.ToDictionary(x => x.Id, x => x.OlsonTimeZone);

			CldrTimeZoneKeyToOlsonTimeZoneMap = CreateCldrTimeZoneKeyToOlsonTimeZoneMap();
		}

		public static string GetTzdbId(string timeZone)
		{
			string result = null;

			if (DateTimeZoneProviders.Tzdb.Ids.Contains(timeZone))
			{
				result = timeZone;
			}
			else if (TimeZoneListItemIdToOlsonTimeZoneMap.ContainsKey(timeZone))
			{
				result = TimeZoneListItemIdToOlsonTimeZoneMap[timeZone];
			}
			else if (CldrTimeZoneKeyToOlsonTimeZoneMap.ContainsKey(timeZone))
			{
				result = CldrTimeZoneKeyToOlsonTimeZoneMap[timeZone];
			}
			else
			{
				var cldrKeyFromListItemId = GetCldrTimeZoneKeyFromTimeZoneListItemId(timeZone);
				if (CldrTimeZoneKeyToOlsonTimeZoneMap.ContainsKey(cldrKeyFromListItemId))
				{
					result = CldrTimeZoneKeyToOlsonTimeZoneMap[cldrKeyFromListItemId];
				}
			}

			return result;
		}

		public static string GetCldrTimeZoneKeyFromTimeZoneListItemId(string id)
		{
			string result;

			var underscorePosition = id.IndexOf('_');
			if (underscorePosition >= 0)
			{
				result = id.Substring(0, underscorePosition);
			}
			else
			{
				result = id;
			}

			return result;
		}

		public static string GetCountryIdFromTimeZoneListItemId(string id)
		{
			string result;

			var underscorePosition = id.IndexOf('_');
			if (underscorePosition >= 0)
			{
				result = id.Substring(underscorePosition + 1);
			}
			else if (id == UtcCldrTimeZoneKey)
			{
				result = CountryIndependentIsoCode;
			}
			else
			{
				result = id.Substring(0, 2);
			}

			result = result.ToUpperInvariant();
			return result;

		}
	}
}