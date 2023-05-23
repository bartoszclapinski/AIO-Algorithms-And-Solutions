using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestSolutions.HackerRank.FindMedian
{
    class FindMedian
    {
        public static int findMedian(List<int> arr)
        {
            arr.Sort();
            return arr[arr.Count / 2];
        }
    }
}
