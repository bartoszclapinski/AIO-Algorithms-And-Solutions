namespace Aio_Algorithms_And_Solutions.Solutions.Exercism;

/*
 *  This is a solution for Bird Watcher exercise on Exercism.org 
 */
public class BirdCount
{
    private readonly int[] _birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this._birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new BirdCount(new int[] {0, 2, 5, 3, 7, 8, 4})._birdsPerDay;
    }

    public int Today()
    {
        return _birdsPerDay[^1];
    }

    public void IncrementTodaysCount()
    {
        //  _birdsPerDay[^1] = _birdsPerDay[_birdsPerDay.Length - 1]
        //  For 8.0 and later, the ^ operator can be used to obtain the last element of an array.
        _birdsPerDay[^1]++;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (int birds in _birdsPerDay)
            if (birds == 0) return true;
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int numberOfBirds = 0;
        for (int i = 0; i < numberOfDays; i++) numberOfBirds += _birdsPerDay[i];

        return numberOfBirds;
    }

    public int BusyDays()
    {
        int busyDays = 0;
        foreach (int birds in _birdsPerDay)
            if (birds > 4) busyDays++;

        return busyDays;
    }    
}