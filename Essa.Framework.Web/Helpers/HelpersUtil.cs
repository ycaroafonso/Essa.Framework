using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Routing;

namespace Essa.Framework.Web.Helpers
{
    public static class HelpersUtil
    {
        public static string ParametrosParaString(this RouteValueDictionary valor)
        {
            return string.Join(" ", valor.Select(c => string.Concat(c.Key.Replace("_", "-"), "=\"", c.Value, "\"")).ToArray());
        }
    }
}
