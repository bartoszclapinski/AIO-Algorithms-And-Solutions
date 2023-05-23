using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestSolutions.HackerRank.SubarrayDivision
{
    class SubarrayDivision
    {
        public static int birthday(List<int> s, int d, int m)
        {
            int result = 0, count = 0;

            for (int i = 0; i < s.Count; i++)
            {
                if ((i + m - 1) < s.Count)
                {
                    for (int j = i; j < (i + m); j++)
                    {
                        result += s[j];
                    }

                    if (result == d) ++count;

                    result = 0;
                }
            }

            return count;
        }

    }
}
