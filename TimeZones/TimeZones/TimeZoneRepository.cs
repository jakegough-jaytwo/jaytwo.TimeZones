using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using jaytwo.Common.Extensions;
using System.Text.RegularExpressions;

namespace jaytwo.TimeZones
{
	public class TimeZoneRepository
	{
		private static TimeZoneRepository _Default = new TimeZoneRepository();
		public static TimeZoneRepository Default
		{
			get
			{
				return _Default;
			}
		}

		public IList<TimeZoneListItem> GetTimeZones()
		{
			return TimeZoneRepositoryInternal.TimeZones;
		}

		public TimeZoneListItem GetTimeZoneById(string id)
		{
			return TimeZoneRepositoryInternal.TimeZones.SingleOrDefault(x => x.Id == id);
		}

		public IList<TimeZoneListItem> GetTimeZonesByCountryId(string countryId)
		{
			return TimeZoneRepositoryInternal.TimeZones
				.Where(x => x.CountryId == countryId)
				.ToList();
		}

		public IList<CountryListItem> GetCountries()
		{
			return TimeZoneRepositoryInternal.Countries;
		}

		public CountryListItem GetCountryById(string id)
		{
			return TimeZoneRepositoryInternal.Countries.SingleOrDefault(x => x.Id == id);
		}

		public static string GetCldrTimeZoneKeyFromTimeZoneListItemId(string id)
		{
			return TimeZoneRepositoryInternal.GetCldrTimeZoneKeyFromTimeZoneListItemId(id);
		}

		public static string GetCountryIdFromTimeZoneListItemId(string id)
		{
			return TimeZoneRepositoryInternal.GetCountryIdFromTimeZoneListItemId(id);
		}
	}
}
