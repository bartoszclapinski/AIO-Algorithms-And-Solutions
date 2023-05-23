using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestSolutions.HackerRank.PermutingTwoArrays
{
    class PermutingTwoArrays
    {
        public static string twoArrays(int k, List<int> A, List<int> B)
        {
            var sortedA = A.OrderBy(a => a).ToList();
            var sortedB = B.OrderByDescending(b => b).ToList();

            for (int i = 0; i < A.Count; i++)
            {
                if (sortedA[i] + sortedB[i] < k) return "NO";
            }
            return "YES";
        }

    }
}
