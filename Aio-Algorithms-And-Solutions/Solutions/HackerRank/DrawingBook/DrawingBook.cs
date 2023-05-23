using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestSolutions.HackerRank.DrawingBook
{
    class DrawingBook
    {
        public static int pageCount(int n, int p)
        {
            if (p > n / 2)
            {
                p = n - p;
                if (n % 2 == 0) p++;
            }
            
            return p / 2;
        }
    }
}
