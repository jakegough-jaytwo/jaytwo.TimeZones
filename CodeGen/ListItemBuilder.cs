using jaytwo.Common.Time;
using jaytwo.TimeZones;
using jaytwo.TimeZones.CodeGen.GeoNames;
using jaytwo.TimeZones.CodeGen.GoogleCalendar;
using jaytwo.TimeZones.CodeGen.Cldr;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace jaytwo.TimeZones.CodeGen
{
    public static class ListItemBuilder
    {
        public static IList<CountryListItem> GetCountries()
        {
            var googleTimeZones = GoogleCalendarTimeZoneParser.GetGoogleCalendarTimeZones();
            var countries = GeoNamesCountryParser.GetGeoNamesCountries();

            return CountryListItemsFromGoogleTimeZones(googleTimeZones, countries);
        }

        private static IList<CountryListItem> CountryListItemsFromGoogleTimeZones(IList<GoogleCalendarTimeZone> googleTimeZones, IList<GeoNamesCountry> countries)
        {
            var countryCodes = googleTimeZones
                .Select(x => x.CountryCode)
                .Distinct()
                .ToList();

            var result = new List<CountryListItem>();

            foreach (var countryCode in countryCodes)
            {
                var country = countries.FilterByISO(countryCode).SingleOrDefault();
                var resultItem = new CountryListItem();
                resultItem.Id = countryCode;
                resultItem.Name = GetCountryName(countryCode, country);

                result.Add(resultItem);
            }

            return result
				.OrderBy(x => x.Id == TimeZoneRepositoryInternal.CountryIndependentIsoCode)
                .ThenBy(x => x.Name)
                .ToList();
        }

        public static IList<TimeZoneListItem> GetTimeZones()
        {
            var googleTimeZones = GoogleCalendarTimeZoneParser.GetGoogleCalendarTimeZones();
            var countries = GeoNamesCountryParser.GetGeoNamesCountries();
			var cldrTimeZoneKeys = CldrTimeZoneKeyParser.GetCldrTimeZoneKeys();

			return TimeZoneListItemsFromGoogleTimeZones(googleTimeZones, countries, cldrTimeZoneKeys);
        }

        private static IList<TimeZoneListItem> TimeZoneListItemsFromGoogleTimeZones(IList<GoogleCalendarTimeZone> googleTimeZones, IList<GeoNamesCountry> countries, IList<CldrTimeZoneKey> cldrTimeZoneKeys)
        {
            var result = new List<TimeZoneListItem>();

            foreach (var googleTimeZone in googleTimeZones)
            {
                var country = countries.FilterByISO(googleTimeZone.CountryCode).SingleOrDefault();
				var cldrKey = cldrTimeZoneKeys.FilterByAlias(googleTimeZone.OlsonTimeZone).SingleOrDefault();
                var resultItem = TimeZoneListItemFromGoogleTimeZone(googleTimeZone, country, cldrKey);
                result.Add(resultItem);
            }

            return result
                .OrderBy(x => !x.IsAssignedToCountry)
                .ThenBy(x => x.CountryName)
                .ThenBy(x => x.DisplayName)
                .ToList();
        }

        private static TimeZoneListItem TimeZoneListItemFromGoogleTimeZone(GoogleCalendarTimeZone googleTimeZone, GeoNamesCountry country, CldrTimeZoneKey cldrTimeZoneKey)
        {
            var result = new TimeZoneListItem();
			result.Id = GetTimeZoneListItemId(googleTimeZone.CountryCode, cldrTimeZoneKey.Name);
			result.CldrTimeZoneKey = cldrTimeZoneKey.Name;

            result.CountryId = googleTimeZone.CountryCode;
            result.OlsonTimeZone = googleTimeZone.OlsonTimeZone;
            result.StandardOffset = GetStandardGmtOffset(googleTimeZone.DisplayText);            
            result.DisplayName = googleTimeZone.DisplayText;
            result.IsAssignedToCountry = GetIsAssignedToCountry(googleTimeZone.CountryCode);
            
			var displayName = GetTimeZoneFriendlyName(googleTimeZone.DisplayText);            
            result.DisplayNameWithoutOffset = displayName;

            var countryName = GetCountryName(googleTimeZone.CountryCode, country);
            result.CountryName = countryName;
            result.DisplayNameWithCountry = GetDisplayNameWithCountry(countryName, googleTimeZone.DisplayText);

            return result;
        }

        private static Regex gmtOffsetRegex = new Regex(@"^\(GMT(?<GMT_OFFSET>[^)]+)\)\s+(?<PLACE>.*)$", RegexOptions.Compiled);
        private static string GetTimeZoneFriendlyName(string timeZoneDisplayText)
        {
            var match = gmtOffsetRegex.Match(timeZoneDisplayText);
            return match.Groups["PLACE"].Value;
        }

        private static string GetStandardGmtOffset(string timeZoneDisplayText)
        {
            var match = gmtOffsetRegex.Match(timeZoneDisplayText);
            return match.Groups["GMT_OFFSET"].Value;
        }

        private static string GetTimeZoneListItemId(string countryIsoCode, string cldrTimeZoneKey)
        {
            if (cldrTimeZoneKey.StartsWith(countryIsoCode, StringComparison.OrdinalIgnoreCase))
			{
				return cldrTimeZoneKey;
			}
			else if (cldrTimeZoneKey == TimeZoneRepositoryInternal.UtcCldrTimeZoneKey)
			{
				return cldrTimeZoneKey;
			}
			else
			{
				return string.Format(CultureInfo.InvariantCulture, "{0}_{1}",
					cldrTimeZoneKey,
					countryIsoCode.ToLower(CultureInfo.InvariantCulture));
			}
        }

        private static bool GetIsAssignedToCountry(string countryCode)
        {
			return (countryCode != TimeZoneRepositoryInternal.CountryIndependentIsoCode);
        }

        private static string GetCountryName(string countryCode, GeoNamesCountry country)
        {
            if (country != null)
            {
                return country.Country;
            }
            else if (!GetIsAssignedToCountry(countryCode))
            {
                return "(Country Independent)";
            }
            else
            {
                throw new InvalidOperationException("Unsupported Country Code: " + countryCode);
            }
        }

        public static string GetDisplayNameWithCountry(string countryName, string displayName)
        {
            return string.Format(CultureInfo.InvariantCulture, "{0} - {1}", countryName, displayName);
        }
    }
}
