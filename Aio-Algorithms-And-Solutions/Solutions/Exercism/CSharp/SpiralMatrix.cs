namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
        var matrix = new int[size, size];

        var rowStart = 0;
        var rowEnd = size - 1;
        var colStart = 0;
        var colEnd = size - 1;

        var counter = 1;

        while (rowStart <= rowEnd && colStart <= colEnd)
        {
            // Fill the top row
            for (var i = colStart; i <= colEnd; i++)
            {
                matrix[rowStart, i] = counter++;
            }
            rowStart++;

            // Fill the right column
            for (var i = rowStart; i <= rowEnd; i++)
            {
                matrix[i, colEnd] = counter++;
            }
            colEnd--;

            // Fill the bottom row
            if (rowStart <= rowEnd)
            {
                for (var i = colEnd; i >= colStart; i--)
                {
                    matrix[rowEnd, i] = counter++;
                }
                rowEnd--;
            }

            // Fill the left column
            if (colStart > colEnd) continue;
            {
                for (var i = rowEnd; i >= rowStart; i--)
                {
                    matrix[i, colStart] = counter++;
                }
                colStart++;
            }
        }

        return matrix;
    }
}
