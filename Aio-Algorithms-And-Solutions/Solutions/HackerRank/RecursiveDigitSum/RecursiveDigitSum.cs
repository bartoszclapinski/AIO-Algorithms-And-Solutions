using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestSolutions.HackerRank.RecursiveDigitSum
{
    class RecursiveDigitSum
    {
        public static int superDigit(string n, int k)
        {
            long sum = 0;
                                     
            for (int i = 0; i < n.Length; ++i) 
                sum += Int32.Parse(n[i].ToString());

            sum *= k;

            if (sum > 9) 
                return superDigit(sum.ToString(), 1);
            else 
                return (int)sum;
        }
    }
}
