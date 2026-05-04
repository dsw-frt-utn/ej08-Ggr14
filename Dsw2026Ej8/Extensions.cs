using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Dsw2026Ej8
{
    internal static class Extensions
    {
        public static string ToProductCode(this string code)
        {
            if (code == null) return "SIN-CODIGO";
            return code.Trim().ToUpper().Replace(" ", "-");
        }
    }
}
