namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private Dictionary<string, int> _roster;

    public GradeSchool()
    {
        _roster = new Dictionary<string, int>();
    }
    
    public bool Add(string student, int grade)
    {
        if (_roster.ContainsKey(student))
        {
            return false; // Indicates that student already exists in the roster
        }
        _roster[student] = grade;
        return true;
    }

    public IEnumerable<string> Roster()
    {
        return _roster
                        .OrderBy(kv => kv.Value)
                        .ThenBy(kv => kv.Key)
                        .Select(kv => kv.Key)
                        .ToArray();
    }

    public IEnumerable<string> Grade(int grade)
    {
        return _roster
                        .Where(kv => kv.Value == grade)
                        .OrderBy(kv => kv.Key)
                        .Select(kv => kv.Key)
                        .ToArray();
    }
}
