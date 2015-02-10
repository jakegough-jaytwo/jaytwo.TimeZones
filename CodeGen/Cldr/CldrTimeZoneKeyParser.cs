using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using jaytwo.Common.Extensions;
using System.Xml;
using System.IO;

namespace jaytwo.TimeZones.CodeGen.Cldr
{
    public static class CldrTimeZoneKeyParser
    {
        public static IList<CldrTimeZoneKey> GetCldrTimeZoneKeys()
        {
            var rawData = EmbeddedResourceUtility.GetEmbeddedResourceAsString(
                typeof(CldrTimeZoneKeyParser).Assembly,
				"jaytwo.TimeZones.CodeGen.Cldr.common.bcp47.timezone.xml");

            return GetCldrTimeZoneKeys(rawData);
        }

        private static IList<CldrTimeZoneKey> GetCldrTimeZoneKeys(string xml)
        {
            return GetCldrTimeZoneKeysInternal(xml).ToList();
        }

        private static IEnumerable<CldrTimeZoneKey> GetCldrTimeZoneKeysInternal(string xml)
        {
            var xmlDocument = new XmlDocument();
            xmlDocument.XmlResolver = null;
            xmlDocument.LoadXml(xml);

            var typeElements = xmlDocument.SelectNodes("/ldmlBCP47/keyword/key/type");

            if (typeElements != null)
            {
                foreach (XmlNode node in typeElements)
                {
                    var result = new CldrTimeZoneKey();
                    result.Name = node.GetXPathValue("./@name");
                    result.Description = node.GetXPathValue("./@description");
					result.Preferred = node.GetXPathValue("./@preferred");

                    var deprecatedString = node.GetXPathValue("./@deprecated");
                    result.IsDeprecated = (deprecatedString ?? bool.FalseString).ParseBoolean();

                    var aliasString = node.GetXPathValue("./@alias");
					result.Aliases = (aliasString ?? string.Empty).Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    yield return result;
                }
            }
        }
    }
}
