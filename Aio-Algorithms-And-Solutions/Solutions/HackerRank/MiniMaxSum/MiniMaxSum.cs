using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestSolutions.HackerRank.MiniMaxSum
{
    class MiniMaxSum
    {
        public static void minMaxSumSolution(List<int> arr)
        {
            arr.Sort();
            int minSum = 0, maxSum = 0;
            foreach (var item in arr)
            {
                minSum += item;
            }

            maxSum = minSum - arr[0];
            minSum -= arr[arr.Count - 1];

            Console.WriteLine(minSum + " " + maxSum);
        }
    }
}
