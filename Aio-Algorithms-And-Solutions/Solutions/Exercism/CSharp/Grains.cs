namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n is <= 0 or > 64)
        {
            throw new ArgumentOutOfRangeException(nameof(n), "Input must be between 1 and 64.");
        }
        return 1UL << (n - 1);
    }

    public static ulong Total()
    {
        return ulong.MaxValue;  // equivalent to 2^64 - 1
    }
}
