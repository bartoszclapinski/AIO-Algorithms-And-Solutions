namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

using System;
using System.Linq;
using System.Text.RegularExpressions;
public static class Acronym
{
    public static string Abbreviate(string phrase) => string.Concat(Regex.Split(phrase, "[^A-Za-z']+").Select(s => char.ToUpper(s[0])));
}