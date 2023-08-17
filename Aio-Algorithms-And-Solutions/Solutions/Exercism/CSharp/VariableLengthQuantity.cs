namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

using System;
using System.Linq;
using System.Collections.Generic;
public static class VariableLengthQuantity
{
    public static uint[] Encode(IEnumerable<uint> numbers) => numbers.SelectMany(n => Split(n).Reverse()).ToArray();
    public static uint[] Decode(uint[] bytes) => Join(bytes).ToArray();
    private static IEnumerable<uint> Split(uint number)
    {
        yield return number & 0x7f;
        number >>= 7;
        while (number != 0)
        {
            yield return (number & 0x7f) | 0x80;
            number >>= 7;
        }
    }
    private static IEnumerable<uint> Join(uint[] bytes)
    {
        if ((bytes.Last() & 0x80) != 0)
            throw new InvalidOperationException();
        var temp = 0U;
        foreach (var n in bytes)
        {
            temp = (temp << 7) + (n & 0x7f);
            if ((n & 0x80) != 0) continue;
            yield return temp;
            temp = 0;
        }
    }
}