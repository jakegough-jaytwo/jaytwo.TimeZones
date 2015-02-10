using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jaytwo.TimeZones
{
    public class TimeZoneListItem
    {
        public string Id { get; set; }
		public string CldrTimeZoneKey { get; set; }
        public string OlsonTimeZone { get; set; }
        public string CountryId { get; set; }
        public string CountryName { get; set; }
        public bool IsAssignedToCountry { get; set; }
        public string DisplayName { get; set; }
        public string DisplayNameWithCountry { get; set; }
        public string StandardOffset { get; set; }
        public string DisplayNameWithoutOffset { get; set; }
    }
}
