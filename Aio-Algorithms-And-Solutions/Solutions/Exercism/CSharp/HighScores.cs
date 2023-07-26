namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private readonly List<int> _scoresList;

    public HighScores(List<int> list)
    {
        _scoresList = list;
    }

    public List<int> Scores()
    {
        return _scoresList;
    }

    public int Latest()
    {
        return _scoresList.Last();
    }

    public int PersonalBest()
    {
        return _scoresList.Max();
    }

    public List<int> PersonalTopThree()
    {
        return _scoresList.OrderByDescending(score => score).Take(3).ToList();
    }
}
