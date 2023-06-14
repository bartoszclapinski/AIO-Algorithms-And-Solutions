using System.Runtime.InteropServices;

namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp.BeautySalonGoesGlobal;

public class Appointment
{
        public static DateTime ShowLocalTime(DateTime dtUtc)
    {
        return dtUtc.ToLocalTime();
    }

    public static DateTime Schedule(string appointmentDateDescription, Location location)
    {
        var localTime = DateTime.Parse(appointmentDateDescription);
        var timeZone = GetTimeZone(location);
        return TimeZoneInfo.ConvertTimeToUtc(localTime, timeZone);
    }

    public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel)
    {
        return alertLevel switch
        {
                        AlertLevel.Early => appointment.AddDays(-1),
                        AlertLevel.Standard => appointment.AddHours(-1).AddMinutes(-45),
                        AlertLevel.Late => appointment.AddMinutes(-30),
                        _ => throw new ArgumentException("Invalid alert level")
        };
    }

    public static bool HasDaylightSavingChanged(DateTime dt, Location location)
    {
        var timeZone = GetTimeZone(location);
        var weekAgo = dt.AddDays(-7);

        return timeZone.IsDaylightSavingTime(dt) != timeZone.IsDaylightSavingTime(weekAgo);
    }

    public static DateTime NormalizeDateTime(string dtStr, Location location)
    {
        try
        {
            var style = location == Location.NewYork ? "M/d/yyyy H:mm:ss" : "d/M/yyyy H:mm:ss";
            return DateTime.ParseExact(dtStr, style, null);
        }
        catch
        {
            return new DateTime(1, 1, 1, 0, 0, 0);
        }
    }

    private static TimeZoneInfo GetTimeZone(Location location)
    {
        string timeZoneId;
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            timeZoneId = location switch
            {
                Location.NewYork => "Eastern Standard Time",
                Location.London => "GMT Standard Time",
                Location.Paris => "W. Europe Standard Time",
                _ => throw new ArgumentException("Invalid location")
            };
        }
        else
        {
            timeZoneId = location switch
            {
                Location.NewYork => "America/New_York",
                Location.London => "Europe/London",
                Location.Paris => "Europe/Paris",
                _ => throw new ArgumentException("Invalid location")
            };
        }
        return TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
    }
}