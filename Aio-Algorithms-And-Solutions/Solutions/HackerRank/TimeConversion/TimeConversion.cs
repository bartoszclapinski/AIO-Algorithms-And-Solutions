using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestSolutions.HackerRank.TimeConversion
{
    class TimeConversion
    {
        public static string timeConversionSolution(string input)
        {
            string hours = input.Substring(0, 2);
            string rest = input.Substring(2, 6);
            string format = input.Substring(8);

            if (format.StartsWith("P") && !hours.Equals("12")) hours = (Int16.Parse(hours) + 12).ToString();
            else if (format.StartsWith("A") && hours.Equals("12")) hours = "00";
            return String.Concat(hours, rest);
        }
    }
}
