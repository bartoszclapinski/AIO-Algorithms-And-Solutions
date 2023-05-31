namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
    }
}