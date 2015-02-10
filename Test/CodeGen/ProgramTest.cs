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
	public static class ProgramTest
	{
		[Test]
		public static void Program_GetRenderedCodeFile()
		{
			var rendered = Program.GetRenderedCodeFile();
			Assert.IsNotNullOrEmpty(rendered);
		}
	}
}
