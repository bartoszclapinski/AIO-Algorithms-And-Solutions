using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestSolutions.HackerRank.XorStrings2
{
    class XorStrings2
    {
        public static string xorStrings2(string s, string t)
        {            
            string result = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s.ToCharArray()[i] == t.ToCharArray()[i]) result += 0;
                else result += 1;
            }

            return result;
        }
    }
}
