using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestSolutions.HackerRank.SalesByMatch
{
    class SalesByMatch
    {
        public static int sockMerchant(int n, List<int> arr)
        {
            int pairs = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach (int i in arr)
            {
                if (map.ContainsKey(i))
                {
                    ++map[i];
                    if (map[i] % 2 == 0) ++pairs;
                }
                else map.Add(i, 1);
            }
            return pairs;
        }
    }
}
