using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestSolutions.HackerRank.MaxMin
{
    class MaxMin
    {
        public static int maxMin(int k, List<int> arr)
        {
            int result = Int32.MaxValue;
            arr.Sort();            

            for (int i = 0; i < arr.Count - k + 1; i++)
            {
                result = Math.Min(result, 
                    Math.Max(arr[i], arr[i + k - 1]) - Math.Min(arr[i], arr[i + k - 1]));                
            }
            return result;
        }

    }
}
