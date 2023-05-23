using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestSolutions.HackerRank.Pangrams
{
    class Pangrams
    {
        public static string pangrams(string s)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            string sortedInput = String.Concat(s
                .ToLower()
                .Where(s => !Char.IsWhiteSpace(s))
                .OrderBy(s => s)
                .Distinct());

            if (sortedInput.Equals(alphabet)) return "pangram";
            else return "not pangram";
        }

    }
}
