using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestSolutions.HackerRank.DynamicArray
{
    class DynamicArray
    {
        public static List<int> dynamicArray(int n, List<List<int>> queries)
        {
            List<List<int>> arr = new List<List<int>>();            
            for (int i = 0; i < n; i++) arr.Add(new List<int>());            

            List<int> result = new List<int>();
            int last = 0;
            
            for (int i = 0; i < queries.Count; i++)
            {
                int x = queries[i][1];
                int y = queries[i][2];
                int index = (x ^ last) % n;

                if (queries[i][0] == 1)
                {
                    arr[index].Add(y);
                }
                else if (queries[i][0] == 2)
                {
                    last = arr[index][y % arr[index].Count];
                    result.Add(last);
                }
            }

            return result;
        }
    }
}
