using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Extensions
{
    public static class StringExtensions
    {
        public static string[] SplitOnWordsArray(this string source)
        {
            return source.Split(new char[] { ' ', '\u000A', ',', '.', ';', ':', '-', '?', '/' , '!'}, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
