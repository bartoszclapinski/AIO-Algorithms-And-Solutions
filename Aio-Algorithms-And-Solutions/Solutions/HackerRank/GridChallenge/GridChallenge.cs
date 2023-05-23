using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestSolutions.HackerRank.GridChallenge
{
    class GridChallenge
    {
        public static string gridChallenge(List<string> grid)
        {            
            for (int i = 0; i < grid.Count; i++)    
            {
                grid[i] = string.Concat(grid[i].OrderBy(ch => ch));    
            }
            
            for (int i = 0; i < grid[0].Length; i++)
            {
                for (int j = 0; j < grid.Count - 1; j++)
                {
                    if (grid[j].ToCharArray()[i] > grid[j + 1].ToCharArray()[i]) return "NO";  
                }
            }

            return "YES";
        }
    }
}
