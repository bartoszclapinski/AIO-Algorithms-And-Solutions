using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestSolutions.HackerRank.CountingSort
{
    class CountingSort
    {
        public static List<int> countingSort(List<int> arr)
        {
            int[] resultArr = new int[100];

            foreach (int i in arr)
            {
                resultArr[i] += 1;
            }

            return resultArr.ToList();
        }

    }
}
