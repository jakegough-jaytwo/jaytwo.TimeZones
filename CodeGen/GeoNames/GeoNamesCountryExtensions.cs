using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaytwo.TimeZones.CodeGen.GeoNames
{
    public static class GeoNamesCountryExtensions
    {
		public static IEnumerable<GeoNamesCountry> FilterByISO(this IEnumerable<GeoNamesCountry> entities, string iso)
        {
            return
				from entity in entities
                where entity.ISO == iso
                select entity;
        }
    }
}
