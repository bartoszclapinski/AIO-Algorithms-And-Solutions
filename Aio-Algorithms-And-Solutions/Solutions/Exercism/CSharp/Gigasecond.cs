namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        return moment.AddSeconds(1e9);
    }
}