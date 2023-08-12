namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

public class LogParser
{
    private const string ValidLine = @"^\[(TRC|DBG|INF|WRN|ERR|FTL)\]";
    private const string SplitLine = @"<[\^*=-]+>";
    private const string QuotedPassword = @""".*password.*""";
    private const string EndOfLine = @"end-of-line\d+";
    private const string WeakPassword = @"password\w+";
    
    public bool IsValidLine(string text) => Regex.IsMatch(text, ValidLine);
    public string[] SplitLogLine(string text) => Regex.Split(text, SplitLine);
    public int CountQuotedPasswords(string lines) => Regex.Matches(lines, QuotedPassword, RegexOptions.IgnoreCase).Count;
    public string RemoveEndOfLineText(string line) => Regex.Replace(line, EndOfLine, string.Empty);
    public string[] ListLinesWithPasswords(string[] lines)
    {
        return (from line in lines let passwordMatch = 
                        Regex.Match(line, WeakPassword, RegexOptions.IgnoreCase) 
                        select passwordMatch == 
                               Match.Empty ? $"--------: {line}" : $"{passwordMatch.Value}: {line}").ToArray();
    }
 
}