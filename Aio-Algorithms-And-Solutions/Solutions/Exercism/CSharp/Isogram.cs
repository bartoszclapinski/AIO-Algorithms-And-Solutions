namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

using System;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        if (string.IsNullOrEmpty(word)) return true;
        
        
        var normalizedWord = word.ToLowerInvariant();
        var chars = normalizedWord.Where(char.IsLetter).ToArray();

        return chars.Distinct().Count() == chars.Length;
    }
}
