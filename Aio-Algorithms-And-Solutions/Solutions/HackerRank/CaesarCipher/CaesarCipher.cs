using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestSolutions.HackerRank.CaesarCipher
{
    class CaesarCipher
    {
        public static string caesarCipher(string s, int k)
        {
            string result = "";            
            char c;
            
            if (k > 26) k = k % 26;

            for (int i = 0; i < s.Length; i++)
            {
                c = s.ToCharArray()[i];
                if (c > 64 && c < 91)
                {
                    c = (char)(c + k);
                    if (c > 90)
                    {
                        c = (char)(64 + (c - 90));
                    }
                }
                else if (c > 96 && c < 123)
                {
                    c = (char)(c + k);
                    if (c > 122)
                    {
                        c = (char)(96 + (c - 122));
                    }
                }               
                
                result += c;
            }

            return result;
        }
    }
}
