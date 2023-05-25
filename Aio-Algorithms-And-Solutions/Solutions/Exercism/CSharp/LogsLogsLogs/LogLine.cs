namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp.LogsLogsLogs;

public class LogLine
{
    public static LogLevel ParseLogLevel(string logLine)
    {
        string logLevel = logLine.Split(':')[0].TrimStart('[').TrimEnd(']');

        return logLevel switch
        {
            "TRC" => LogLevel.Trace,
            "DBG" => LogLevel.Debug,
            "INF" => LogLevel.Info,
            "WRN" => LogLevel.Warning,
            "ERR" => LogLevel.Error,
            "FTL" => LogLevel.Fatal,
            _ => LogLevel.Unknown    
        };
    }

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        return $"{(int)logLevel}:{message}";
    }    
}