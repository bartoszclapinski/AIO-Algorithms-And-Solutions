namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.NeedForSpeed;

class RemoteControlCar
{
    private readonly int _speed;
    private int _distance;
    private readonly int _batteryDrain;
    private int _battery;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this._speed = speed;
        this._batteryDrain = batteryDrain;
        this._battery = 100;
        this._distance = 0;
    }

    public bool BatteryDrained()
    {
        if (_battery < _batteryDrain) return true;
        else return false;
    }

    public int DistanceDriven()
    {
        return _distance;
    }

    public void Drive()
    {
        if (_battery >= _batteryDrain) 
        {
            _distance += _speed;
            _battery -= _batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}