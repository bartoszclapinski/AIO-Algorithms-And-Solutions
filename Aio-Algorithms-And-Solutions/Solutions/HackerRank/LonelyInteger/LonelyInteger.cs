using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestSolutions.HackerRank.LonelyInteger
{
    class LonelyInteger
    {
        public static int lonelyInteger(List<int> a)
        {
            int result = 0;

            foreach (int i in a)
            {
                result ^= i;
            }

            return result;
        }
    }
}
