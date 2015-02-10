using jaytwo.TimeZones.CodeGen;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaytwo.TimeZones.Test.CodeGen
{
	[TestFixture]
	public static class ListItemBuilderTests
	{
		[Test]
		public static void ListItemBuilder_GetTimeZones()
		{
			var timeZones = ListItemBuilder.GetTimeZones();
		}

		[Test]
		public static void ListItemBuilder_TimeZoneListItem_Id_is_unique()
		{
			var timeZones = ListItemBuilder.GetTimeZones();

			var duplicates = timeZones
				.GroupBy(x => x.Id)
				.Where(x => x.Count() > 1)
				.SelectMany(x => x)
				.ToList();

			Assert.AreEqual(0, duplicates.Count);
		}
	}
}
