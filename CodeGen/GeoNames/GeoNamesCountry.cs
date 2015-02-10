using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaytwo.TimeZones.CodeGen.GeoNames
{
	public class GeoNamesCountry
	{
		public string ISO { get; set; }
		public string ISO3 { get; set; }
		public string ISO_Numeric { get; set; }
		public string fips { get; set; }
		public string Country { get; set; }
		public string Capital { get; set; }
		public string Area_in_sq_km { get; set; }
		public string Population { get; set; }
		public string Continent { get; set; }
		public string tld { get; set; }
		public string CurrencyCode { get; set; }
		public string CurrencyName { get; set; }
		public string Phone { get; set; }
		public string Postal_Code_Format { get; set; }
		public string Postal_Code_Regex { get; set; }
		public string Languages { get; set; }
		public string geonameid { get; set; }
		public string neighbours { get; set; }
		public string EquivalentFipsCode { get; set; }
	}
}
