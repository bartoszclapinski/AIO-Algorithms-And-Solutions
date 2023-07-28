namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

using System;

public class Clock
{
    private const int HoursInDay = 24;
    private const int MinutesInHour = 60;
    private readonly int _totalMinutes;

    public Clock(int hours, int minutes)
    {
        _totalMinutes = hours * MinutesInHour + minutes;
        _totalMinutes %= HoursInDay * MinutesInHour;
        if (_totalMinutes < 0) _totalMinutes += HoursInDay * MinutesInHour;
    }

    public Clock Add(int minutesToAdd)
    {
        return new Clock(0, _totalMinutes + minutesToAdd);
    }

    public Clock Subtract(int minutesToSubtract)
    {
        return new Clock(0, _totalMinutes - minutesToSubtract);
    }

    public override bool Equals(object obj)
    {
        if (obj is Clock otherClock)
        {
            return _totalMinutes == otherClock._totalMinutes;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return _totalMinutes.GetHashCode();
    }

    public override string ToString()
    {
        return $"{_totalMinutes / MinutesInHour:D2}:{_totalMinutes % MinutesInHour:D2}";
    }
}
