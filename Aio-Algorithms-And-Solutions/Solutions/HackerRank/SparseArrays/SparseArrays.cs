using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestSolutions.HackerRank.SparseArrays
{
    class SparseArrays
    {
        public static List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            List<int> result = new List<int>();
            Dictionary<string, int> map = new Dictionary<string, int>();

            foreach (string s in strings)
            {
                if (map.ContainsKey(s)) ++map[s];
                else map.Add(s, 1);
            }

            foreach (string q in queries)
            {
                if (map.ContainsKey(q)) result.Add(map[q]);
                else result.Add(0);
            }

            return result;
        }

    }
}
