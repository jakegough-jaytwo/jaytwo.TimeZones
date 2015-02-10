using jaytwo.Common;
using jaytwo.Common.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace jaytwo.TimeZones.CodeGen.GoogleCalendar
{
	public static class GoogleCalendarTimeZoneParser
	{
        public static IList<GoogleCalendarTimeZone> GetGoogleCalendarTimeZones()
		{
            // https://www.google.com/calendar/fetchTZ
            // download and paste contents into fetchTZ emvedded resource
            // (you need to be logged in to your calendar first)
            
            var rawData = EmbeddedResourceUtility.GetEmbeddedResourceAsString(
                typeof(GoogleCalendarTimeZoneParser).Assembly,
				"jaytwo.TimeZones.CodeGen.GoogleCalendar.fetchTZ");

            var unescapedData = UnescapeJavaScriptOctal(rawData);
            return GetGoogleCalendarTimeZones(unescapedData);
		}

        public static string UnescapeJavaScriptOctal(string escaped)
        {
            const string pattern = "\\\\(?<OCTAL_VALUE>[0-8]+)";

            return Regex.Replace(
                escaped,
                pattern, x =>
                {
                    var octalValue = x.Groups["OCTAL_VALUE"].Value;
                    var asNumeric = Convert.ToInt32(octalValue, 8);
                    var resultChar = Convert.ToChar(asNumeric);
                    var unescapedString = resultChar.ToString();
                    var result = HttpUtility.JavaScriptStringEncode(unescapedString);

                    return result;
                });
        }

        public static IList<GoogleCalendarTimeZone> GetGoogleCalendarTimeZones(string json)
		{
			return InternalGetGoogleCalendarTimeZones(json).ToList();
		}

        private static IEnumerable<GoogleCalendarTimeZone> InternalGetGoogleCalendarTimeZones(string json)
		{
			var obj = JsonConvert.DeserializeObject<JArray>(json);

			var countryCodes = obj.Where(x => x.Type == JTokenType.String)
				.Select(x => x.ToString())
				.ToList();

			var arrays = obj.Where(x => x.Type == JTokenType.Array)
				.Select(x => x.ToArray().Select(y => y.ToString()).ToList())
				.ToList();

			if (countryCodes.Count != arrays.Count)
			{
				throw new Exception("more strings than arrays");
			}

			for (int i = 0; i < countryCodes.Count; i++)
			{
				var countryCode = countryCodes[i];
				var itemArray = arrays[i];

				if ((itemArray.Count % 3) != 0)
				{
					throw new Exception("arrays not divisible by 3");
				}

				var timeZonesInCountry = (itemArray.Count / 3);

				for (int j = 0; j < timeZonesInCountry; j++)
				{
					var timeZoneIndex = (j * 3);
					var displayTextIndex = timeZoneIndex + 1;
					var otherInformationIndex = timeZoneIndex + 2;

                    var resultItem = new GoogleCalendarTimeZone();
					resultItem.CountryCode = countryCode;
					resultItem.OlsonTimeZone = itemArray[timeZoneIndex];
					resultItem.DisplayText = itemArray[displayTextIndex];
					resultItem.OtherInformation = itemArray[otherInformationIndex];

					yield return resultItem;
				}
			}
		}
	}
}
