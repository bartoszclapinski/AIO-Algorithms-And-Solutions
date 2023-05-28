namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp;

public class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        return speed switch
        {
            0 => 0.0,
            > 0 and < 5 => 1.0,
            < 9 => 0.9,
            9 => 0.8,
            _ => 0.77
        };
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return 221 * SuccessRate(speed) * speed;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)(ProductionRatePerHour(speed) / 60);
    }    
}