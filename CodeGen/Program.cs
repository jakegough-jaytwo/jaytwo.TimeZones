using jaytwo.Common.Time;
using jaytwo.TimeZones.CodeGen.GeoNames;
using jaytwo.TimeZones.CodeGen.GoogleCalendar;
using jaytwo.TimeZones.CodeGen.Cldr;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace jaytwo.TimeZones.CodeGen
{
	public static class Program
	{
		public static void Main()
		{            
			var rendered = GetRenderedCodeFile();

			var tempFile = Path.GetTempFileName();
			using (var file = File.CreateText(tempFile))
			{
				file.Write(rendered);
			}

            Process.Start("notepad.exe", tempFile);

            Thread.Sleep(500);
            File.Delete(tempFile);

            Console.WriteLine("Code generation complete.  Press any key to exit.");
			Console.ReadKey();
		}

		public static string GetRenderedCodeFile()
		{
			var localVariables = new Dictionary<string, object>();
			localVariables.Add("renderTime", TimeUtility.GetSortableTimeString(DateTime.Now));

			var countries = ListItemBuilder.GetCountries();
			localVariables.Add("countries", countries);

			var timeZones = ListItemBuilder.GetTimeZones();
			localVariables.Add("timeZones", timeZones);

			var cldrTimeZoneMap = CldrTimeZoneUtility.CreateCldrTimeZoneKeyToOlsonTimeZoneMap();
			localVariables.Add("cldrTimeZoneMap", cldrTimeZoneMap);

			var templateContent = EmbeddedResourceUtility.GetEmbeddedResourceAsString(
					typeof(Program).Assembly,
					"jaytwo.TimeZones.CodeGen.TimeZoneRepositoryInternal.template.txt");

			var rendered = DotLiquidUtility.Render(templateContent, localVariables);
			return rendered;
		}
	}
}
