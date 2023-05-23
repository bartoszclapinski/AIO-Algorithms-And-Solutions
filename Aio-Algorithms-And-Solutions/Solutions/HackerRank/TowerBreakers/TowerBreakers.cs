using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestSolutions.HackerRank.TowerBreakers
{
    class TowerBreakers
    {
        public static int towerBreakers(int n, int m)
        {
            if (m == 1 || n % 2 == 0) return 2;
            else return 1;
        }
    }
}
