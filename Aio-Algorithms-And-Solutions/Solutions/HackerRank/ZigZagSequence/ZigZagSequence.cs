using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestSolutions.HackerRank.ZigZagSequence
{
    class ZigZagSequence
    {
        public static void findZigZagSequence(List<int> a, int n)
        {
            a.Sort();
            int mid = (n + 1) / 2 - 1;
            int temp = a[mid];
            a[mid] = a[n - 1];
            a[n - 1] = temp;

            int st = mid + 1;
            int ed = n - 2;
            while (st <= ed)
            {
                temp = a[st];
                a[st] = a[ed];
                a[ed] = temp;
                st++;
                ed--;
            }

            for (int i = 0; i < n; i++)
            {
                if (i > 0) Console.Write(" ");
                Console.Write(a[i]);
            }
            Console.WriteLine();
        }
    }
}
