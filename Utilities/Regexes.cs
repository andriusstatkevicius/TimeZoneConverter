using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Utilities
{
    public static class Regexes
    {
        public static RegexOptions regexOptions = RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Multiline;
        public static Regex Table = new Regex(@">Supported\s*IANA\s*Time\s*Zones(?:[^>]*>){3,6}\s*<table>\s*<tr>((?s).*)table", regexOptions);
        public static Regex Entries = new Regex(@"tr>\s*<td>([^<]*)<(?:[^>]*>){2}([^<]*)<", regexOptions);

        public static string TryGetString(this MatchCollection input)
        {
            try
            {
                string result = input[0].Groups[0].Value.Trim();
                return result;
            }
            catch (ArgumentOutOfRangeException)
            {
                return null;
            }
        }

        public static List<string[]> TryGetArray(this MatchCollection input)
        {
            try
            {
                List<string[]> result = input.Cast<Match>().Select(match => match.Groups.Cast<Group>()
                                                                                        .Skip(1)
                                                                                        .Select(group => group.Value.Trim())
                                                                                        .ToArray()).ToList();
                return result;
            }
            catch (ArgumentOutOfRangeException)
            {
                return null;
            }
        }
    }
}
