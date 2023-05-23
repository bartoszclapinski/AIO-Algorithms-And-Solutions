using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestSolutions.HackerRank.SherlockAndArray
{
    class SherlockAndArray
    {
        public static string balancedSums (List<int> arr)
        {
            int size = arr.Count;      

            if (size == 1) return "YES";
            if (size == 2) return "NO";

            int sum = 0;
            foreach (int i in arr) sum += i;

            int left = 0;
            int right = sum - arr[0];
            if (left == right) return "YES";

            for (int i = 1; i <size - 1; ++i)
            {
                left += arr[i - 1];
                right -= arr[i];
                if (left == right) return "YES";
            }

            left = sum - arr[size - 1];
            right = 0;
            if (left == right) return "YES";

            return "NO";
        }
    }
}
