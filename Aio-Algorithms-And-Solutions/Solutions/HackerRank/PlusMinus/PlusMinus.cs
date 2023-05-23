using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestSolutions.HackerRank.PlusMinus
{
    class PlusMinus
    {
        public static void plusMinusSolution(List<int> arr)
        {
            var elements = arr.Count;
            int positives = 0, negatives = 0, zeros = 0;

            foreach (int i in arr)
            {
                if (i > 0) ++positives;
                else if (i < 0) ++negatives;
                else ++zeros;
            }

            double numOfPositives, numOfNegatives, numOfZeros;
            numOfPositives = (double)positives / elements;
            numOfNegatives = (double)negatives / elements;
            numOfZeros = (double)zeros / elements;

            Console.WriteLine(numOfPositives.ToString("0.000000"));
            Console.WriteLine(numOfNegatives.ToString("0.000000"));
            Console.WriteLine(numOfZeros.ToString("0.000000"));
        }
    }
}
