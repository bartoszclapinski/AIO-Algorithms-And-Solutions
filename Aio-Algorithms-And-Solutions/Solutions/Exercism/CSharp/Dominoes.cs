namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

using System;
using System.Linq;
using System.Collections.Generic;
public static class Dominoes
{
    public static bool CanChain(IEnumerable<(int, int)> dominoes) => TryChain(dominoes.ToList(), (0, 0));
    private static bool TryChain(IReadOnlyList<(int, int)> dominoes, (int first, int last) state)
    {
        if (dominoes.Count == 0 && state.last == state.first)
            return true;                        
        for (var i = 0; i < dominoes.Count; i++)
        {
            var (a, b) = dominoes[i];
            if (state.last == 0) state = (a, b);
            else if (state.last == a) state.last = b;
            else if (state.last == b) state.last = a;
            else continue;
            var dominoesCopy = new List<(int, int)>(dominoes);
            dominoesCopy.RemoveAt(i);
            if (TryChain(dominoesCopy, state)) return true;                    
        }
        return false;
    }
}