using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaytwo.TimeZones.CodeGen.Cldr
{
	public static class CldrTimeZoneKeyExtensions
	{
		public static IEnumerable<CldrTimeZoneKey> FilterByAlias(this IEnumerable<CldrTimeZoneKey> entities, string alias)
		{
			return
				from entity in entities
				where entity.Aliases.Any(x => x == alias)
				select entity;
		}
	}
}
