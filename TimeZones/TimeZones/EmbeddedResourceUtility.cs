using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using jaytwo.Common.Extensions;
using System.Reflection;

namespace jaytwo.TimeZones
{
    internal static class EmbeddedResourceUtility
    {
        public static string GetEmbeddedResourceAsString(Assembly assembly, string resourceName)
        {
            using (var stream = assembly.GetManifestResourceStream(resourceName))
            using (var reader = stream.GetReader())
            {
                return reader.ReadToEnd();
            }
        }
    }
}
