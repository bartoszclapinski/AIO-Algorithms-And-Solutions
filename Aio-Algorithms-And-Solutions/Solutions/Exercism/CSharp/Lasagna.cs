namespace Aio_Algorithms_And_Solutions.Solutions.Exercism;

public class Lasagna
{
    public int ExpectedMinutesInOven() => 40;
    
    public int RemainingMinutesInOven(int minutes) => ExpectedMinutesInOven() - minutes;
    
    public int PreparationTimeInMinutes(int layers) => layers * 2;
    
    public int ElapsedTimeInMinutes(int layers, int time) => layers * 2 + time;
}