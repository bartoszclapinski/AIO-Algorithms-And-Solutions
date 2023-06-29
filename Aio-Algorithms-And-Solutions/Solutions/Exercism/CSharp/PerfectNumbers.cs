namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

using System;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number <= 0)
            throw new ArgumentOutOfRangeException(nameof(number), "Number must be positive.");

        var sum = 0;
        for (var i = 1; i < number; i++)
        {
            if (number % i == 0)
                sum += i;
        }

        if (sum == number)
            return Classification.Perfect;
        return sum > number ? Classification.Abundant : Classification.Deficient;
    }
}
