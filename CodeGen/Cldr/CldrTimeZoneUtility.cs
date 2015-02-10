using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaytwo.TimeZones.CodeGen.Cldr
{
	public static class CldrTimeZoneUtility
	{
		private static readonly IList<CldrTimeZoneKey> CldrTimeZoneKeys = CldrTimeZoneKeyParser.GetCldrTimeZoneKeys();

		public static string GetOlsonTimeZone(string cldrTimeZoneKeyName)
		{
			var cldrEntry = CldrTimeZoneKeys.SingleOrDefault(x => x.Name == cldrTimeZoneKeyName);

			if (cldrEntry != null)
			{
				if (!string.IsNullOrEmpty(cldrEntry.Preferred))
				{
					return GetOlsonTimeZone(cldrEntry.Preferred);
				}
				else
				{
					return cldrEntry.Aliases.FirstOrDefault();
				}
			}

			return null;
		}

		public static IList<string[]> CreateCldrTimeZoneKeyToOlsonTimeZoneMap()
		{
			var result = new List<string[]>();

            foreach (var key in CldrTimeZoneKeys.OrderBy(x => x.Name))
			{
				var olsonTimeZone = GetOlsonTimeZone(key.Name);
				result.Add(new[] { key.Name, olsonTimeZone });
			}

			return result;
		}

	}
}
