using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestSolutions.HackerRank.DiagonalDifference
{
    class DiagonalDifference
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                sum += arr[i][i] - arr[i][arr[i].Count - i - 1];
            }

            return Math.Abs(sum);
        }

    }
}
