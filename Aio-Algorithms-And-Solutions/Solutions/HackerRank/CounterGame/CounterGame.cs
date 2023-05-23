using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestSolutions.HackerRank.CounterGame
{
    class CounterGame
    {
        public static string counterGame(long n)
        {
            int player = 0;

            while (n != 1)
            {
                int pow = 0;
                long max = n;

                while (max > 1)
                {
                    max >>= 1;
                    pow++;
                }

                long minPow = 1L << pow;

                if (n - minPow == 0)
                {
                    n = n >> 1;
                }
                else
                {
                    n -= minPow;
                }

                player++;
            }
            return (player & 1) != 0 ? "Louise" : "Richard";

        }
    }
}
