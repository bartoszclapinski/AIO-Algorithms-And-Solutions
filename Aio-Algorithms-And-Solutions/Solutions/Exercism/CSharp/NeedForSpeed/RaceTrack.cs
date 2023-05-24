namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.NeedForSpeed;

class RaceTrack
{
    private readonly int _distance;
    
    public RaceTrack(int distance)
    {
        this._distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained())
        {
            car.Drive();
            if (car.DistanceDriven() >= _distance) return true;
        }
        return false;
    }
}