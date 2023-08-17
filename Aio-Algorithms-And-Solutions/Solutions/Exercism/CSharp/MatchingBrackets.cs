namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

using System;
using System.Collections.Generic;
public static class MatchingBrackets
{
    private static readonly Dictionary<char, char> BracketDict = new () { { '{', '}' }, { '[', ']' }, { '(', ')' }, };
    public static bool IsPaired(string input)
    {
        var bracketStack = new Stack<char>();
        foreach(var character in input)
        {
            if(BracketDict.TryGetValue(character, out var value)) bracketStack.Push(value);
            else if(BracketDict.ContainsValue(character) && (!bracketStack.TryPop(out char popped) || popped != character))
                return false;
        }
        return bracketStack.Count == 0;
    }
}