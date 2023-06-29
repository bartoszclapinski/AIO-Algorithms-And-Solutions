namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

using System;
using System.Collections.Generic;

public static class ResistorColorDuo
{
    private static readonly Dictionary<string, int> ColorValues = new Dictionary<string, int>
    {
                    ["black"] = 0,
                    ["brown"] = 1,
                    ["red"] = 2,
                    ["orange"] = 3,
                    ["yellow"] = 4,
                    ["green"] = 5,
                    ["blue"] = 6,
                    ["violet"] = 7,
                    ["grey"] = 8,
                    ["white"] = 9
    };

    public static int Value(string[] colors)
    {
        if (colors.Length < 2)
        {
            throw new ArgumentException("At least two colors required.");
        }

        return 10 * ColorValues[colors[0]] + ColorValues[colors[1]];
    }
}
