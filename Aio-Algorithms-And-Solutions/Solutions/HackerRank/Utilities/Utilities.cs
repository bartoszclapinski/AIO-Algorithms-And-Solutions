using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestSolutions.HackerRank.Utilities
{
    class Utilities
    {
        public static void showListItems(List<int> arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public static void showListItems(List<List<int>> arr)
        {
            foreach (List<int> item in arr)
            {
                foreach (int item2 in item)
                {
                    Console.Write(item2 + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
