using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestSolutions.HackerRank.FlippingMatrix
{
    class FlippingMatrix
    {
        public static int flippingMatrix(List<List<int>> matrix)
        {
            int sum = 0;            
            int size = matrix.Count;
            int fixedSize = size / 2;

            for (int i = 0; i < fixedSize; i++)
            {
                for (int j = 0; j < fixedSize; j++)
                {
                    sum +=  Math.Max(matrix[i][j],
                            Math.Max(matrix[i][size-1-j],
                            Math.Max(matrix[size-1-i][j], matrix[size-1-i][size-1-j])));                   
                }
            } 
            
            return sum;
        }

    }
}
