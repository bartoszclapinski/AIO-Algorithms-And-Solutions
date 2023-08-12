namespace Aio_Algorithms_And_Solutions.Solutions.Exercism.CSharp.RemoteControlCleanup;

public class RemoteControlCar
{
    public string CurrentSponsor { get; private set; }
    private Speed _currentSpeed;
    public CTelemetry Telemetry;
    public RemoteControlCar() => Telemetry = new RemoteControlCar.CTelemetry(this);
    public string GetSpeed() => _currentSpeed.ToString();
    private void SetSponsor(string sponsorName) => CurrentSponsor = sponsorName;
    private void SetSpeed(Speed speed) => _currentSpeed = speed;
    
    public class CTelemetry
    {
        private readonly RemoteControlCar _parent;
        public CTelemetry(RemoteControlCar parent) => this._parent = parent;
        public void Calibrate() { }
        public bool SelfTest() => true;
        public void ShowSponsor(string sponsorName) => _parent.SetSponsor(sponsorName);
        public void SetSpeed(decimal amount, string unitsString)
        {
            SpeedUnits speedUnits = (unitsString == "cps") 
                            ? SpeedUnits.CentimetersPerSecond 
                            : SpeedUnits.MetersPerSecond;
            _parent.SetSpeed(new Speed(amount, speedUnits));
        }
    }

    private enum SpeedUnits { MetersPerSecond, CentimetersPerSecond }

    readonly struct Speed
    {
        private decimal Amount { get; }
        private SpeedUnits SpeedUnits { get; }
        public Speed(decimal amount, SpeedUnits speedUnits) => (this.Amount, this.SpeedUnits) = (amount, speedUnits);
        public override string ToString() => (SpeedUnits == SpeedUnits.CentimetersPerSecond)
                        ? $"{Amount} centimeters per second"
                        : $"{Amount} meters per second";
    }
}