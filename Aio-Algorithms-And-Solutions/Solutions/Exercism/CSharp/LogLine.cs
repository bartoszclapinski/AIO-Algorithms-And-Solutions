namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

public class LogLine
{
    public static string Message(string logLine)
    {
        var message = logLine.Trim();

        var colonIndex = message.IndexOf(':');

        if (colonIndex >= 0 && colonIndex < message.Length - 1)
            message = message[(colonIndex + 1)..].TrimStart();

        return message;
    }

    public static string LogLevel(string logLine)
    {
        var startIndex = logLine.IndexOf('[');
        var endIndex = logLine.IndexOf(']');

        if (startIndex < 0 || endIndex <= startIndex) return string.Empty;
        var logLevel = logLine.Substring(startIndex + 1, endIndex - startIndex - 1).ToLower();
        return logLevel;

    }

    public static string Reformat(string logLine)
    {
        var logLevel = LogLevel(logLine);
        var message = Message(logLine);

        var reformattedLogLine = $"{message} ({logLevel})";

        return reformattedLogLine;
    }    
}