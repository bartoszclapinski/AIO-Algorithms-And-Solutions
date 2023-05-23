using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestSolutions.HackerRank.SumVsXor
{
    class SumVsXor
    {
        public static long sumXor(long n)
        {
            long count = 0;
            while (n != 0)
            {
                count += n % 2 == 0 ? 1 : 0;
                n /= 2;
            }

            count = (long) Math.Pow(2, count);
            return count;
        }
    }
}
 