using DotLiquid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jaytwo.Common.Extensions;
using jaytwo.Common.Collections;
using System.Web.Script.Serialization;
using System.Collections;

namespace jaytwo.TimeZones.CodeGen
{
    public static class DotLiquidUtility
    {
        public static string Render(string templateContent, IDictionary<string, object> variables)
        {
            var renderParameters = GetRenderParameters(variables);
            var template = Template.Parse(templateContent);
            return template.Render(renderParameters);
        }

        private static RenderParameters GetRenderParameters(IDictionary<string, object> variables)
        {
            var serializer = new JavaScriptSerializer();
            var serialized = serializer.Serialize(variables);
            var deserialized = serializer.Deserialize<Dictionary<string, object>>(serialized);
            var localVariablesHash = Hash.FromDictionary(deserialized);
            var result = new RenderParameters() { LocalVariables = localVariablesHash };
            return result;
        }

    }
}
