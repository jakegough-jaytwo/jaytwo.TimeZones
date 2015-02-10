using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jaytwo.Common.Extensions;
using jaytwo.Common;

namespace jaytwo.TimeZones.CodeGen.GeoNames
{
	public static class GeoNamesCountryParser
	{
        // http://download.geonames.org/export/dump/countryInfo.txt
        // download and paste contents into countryInfo.txt emvedded resource

        public static IList<GeoNamesCountry> GetGeoNamesCountries()
        {
            var rawData = EmbeddedResourceUtility.GetEmbeddedResourceAsString(
                typeof(GeoNamesCountryParser).Assembly,
				"jaytwo.TimeZones.CodeGen.GeoNames.countryInfo.txt");

            return GetGeoNamesCountriesFromCsvData(rawData);
        }

        private static IList<GeoNamesCountry> GetGeoNamesCountriesFromCsvData(string csvData)
		{
			using (var reader = new StringReader(csvData))
			{
				return GetGeoNamesCountriesFromCsvData(reader).ToList();
			}
		}

        private static IEnumerable<GeoNamesCountry> GetGeoNamesCountriesFromCsvData(TextReader reader)
		{
			using (var parser = new CsvParser(reader))
			{
				parser.Configuration.Comment = '#';
				parser.Configuration.Delimiter = "\t";

				string[] csvValues;
				while ((csvValues = parser.Read()) != null)
				{
                    yield return FromCsvValues(csvValues);
				}
			}
		}

		private static GeoNamesCountry FromCsvValues(string[] csvValues)
		{
           var result = new GeoNamesCountry();
			result.ISO = csvValues[GeoNamesCountryColumnIndexes.ISO];
			result.ISO3 = csvValues[GeoNamesCountryColumnIndexes.ISO3];
			result.ISO_Numeric = csvValues[GeoNamesCountryColumnIndexes.ISO_Numeric];
			result.fips = csvValues[GeoNamesCountryColumnIndexes.fips];
			result.Country = csvValues[GeoNamesCountryColumnIndexes.Country];
			result.Capital = csvValues[GeoNamesCountryColumnIndexes.Capital];
			result.Area_in_sq_km = csvValues[GeoNamesCountryColumnIndexes.Area_in_sq_km];
			result.Population = csvValues[GeoNamesCountryColumnIndexes.Population];
			result.Continent = csvValues[GeoNamesCountryColumnIndexes.Continent];
			result.tld = csvValues[GeoNamesCountryColumnIndexes.tld];
			result.CurrencyCode = csvValues[GeoNamesCountryColumnIndexes.CurrencyCode];
			result.CurrencyName = csvValues[GeoNamesCountryColumnIndexes.CurrencyName];
			result.Phone = csvValues[GeoNamesCountryColumnIndexes.Phone];
			result.Postal_Code_Format = csvValues[GeoNamesCountryColumnIndexes.Postal_Code_Format];
			result.Postal_Code_Regex = csvValues[GeoNamesCountryColumnIndexes.Postal_Code_Regex];
			result.Languages = csvValues[GeoNamesCountryColumnIndexes.Languages];
			result.geonameid = csvValues[GeoNamesCountryColumnIndexes.geonameid];
			result.neighbours = csvValues[GeoNamesCountryColumnIndexes.neighbours];
			result.EquivalentFipsCode = csvValues[GeoNamesCountryColumnIndexes.EquivalentFipsCode];

			return result;
		}
	}

}
